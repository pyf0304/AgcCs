
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDGRegionFldsWApi
 表名:DGRegionFlds(00050113)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:07
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
public static class  clsDGRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetmId(this clsDGRegionFldsEN objDGRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objDGRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.mId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.mId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.mId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetRegionId(this clsDGRegionFldsEN objDGRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, conDGRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conDGRegionFlds.RegionId);
objDGRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.RegionId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.RegionId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.RegionId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetFldId(this clsDGRegionFldsEN objDGRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conDGRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conDGRegionFlds.FldId);
objDGRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.FldId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.FldId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.FldId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutFldId">OutFldId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetOutFldId(this clsDGRegionFldsEN objDGRegionFldsEN, string strOutFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutFldId, 8, conDGRegionFlds.OutFldId);
clsCheckSql.CheckFieldForeignKey(strOutFldId, 8, conDGRegionFlds.OutFldId);
objDGRegionFldsEN.OutFldId = strOutFldId; //OutFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.OutFldId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.OutFldId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.OutFldId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strSortExpression">排序表达式</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetSortExpression(this clsDGRegionFldsEN objDGRegionFldsEN, string strSortExpression, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSortExpression, 50, conDGRegionFlds.SortExpression);
objDGRegionFldsEN.SortExpression = strSortExpression; //排序表达式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.SortExpression) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.SortExpression, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.SortExpression] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetSeqNum(this clsDGRegionFldsEN objDGRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSeqNum, conDGRegionFlds.SeqNum);
objDGRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.SeqNum) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.SeqNum, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.SeqNum] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strHeaderText">列头</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetHeaderText(this clsDGRegionFldsEN objDGRegionFldsEN, string strHeaderText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHeaderText, 100, conDGRegionFlds.HeaderText);
objDGRegionFldsEN.HeaderText = strHeaderText; //列头
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.HeaderText) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.HeaderText, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.HeaderText] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strToolTipText">提示文字</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetToolTipText(this clsDGRegionFldsEN objDGRegionFldsEN, string strToolTipText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strToolTipText, 150, conDGRegionFlds.ToolTipText);
objDGRegionFldsEN.ToolTipText = strToolTipText; //提示文字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.ToolTipText) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.ToolTipText, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.ToolTipText] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strCtlTypeId">控件类型号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetCtlTypeId(this clsDGRegionFldsEN objDGRegionFldsEN, string strCtlTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCtlTypeId, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldLen(strCtlTypeId, 2, conDGRegionFlds.CtlTypeId);
clsCheckSql.CheckFieldForeignKey(strCtlTypeId, 2, conDGRegionFlds.CtlTypeId);
objDGRegionFldsEN.CtlTypeId = strCtlTypeId; //控件类型号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.CtlTypeId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.CtlTypeId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.CtlTypeId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strDgFuncTypeId">Dg功能类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetDgFuncTypeId(this clsDGRegionFldsEN objDGRegionFldsEN, string strDgFuncTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
clsCheckSql.CheckFieldForeignKey(strDgFuncTypeId, 4, conDGRegionFlds.DgFuncTypeId);
objDGRegionFldsEN.DgFuncTypeId = strDgFuncTypeId; //Dg功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.DgFuncTypeId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.DgFuncTypeId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.DgFuncTypeId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSort">是否需要排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsNeedSort(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, conDGRegionFlds.IsNeedSort);
objDGRegionFldsEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsNeedSort) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsNeedSort, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsNeedSort] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefaultSort">是否默认排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsDefaultSort(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsDefaultSort, string strComparisonOp="")
	{
objDGRegionFldsEN.IsDefaultSort = bolIsDefaultSort; //是否默认排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsDefaultSort) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsDefaultSort, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsDefaultSort] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsTransToChkBox">是否转换成CheckBox</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsTransToChkBox(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsTransToChkBox, string strComparisonOp="")
	{
objDGRegionFldsEN.IsTransToChkBox = bolIsTransToChkBox; //是否转换成CheckBox
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsTransToChkBox) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsTransToChkBox, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsTransToChkBox] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsVisible">是否显示</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsVisible(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsVisible, string strComparisonOp="")
	{
objDGRegionFldsEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsVisible) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsVisible, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsVisible] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsFuncFld">是否功能字段</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetIsFuncFld(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolIsFuncFld, string strComparisonOp="")
	{
objDGRegionFldsEN.IsFuncFld = bolIsFuncFld; //是否功能字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.IsFuncFld) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.IsFuncFld, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.IsFuncFld] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetInUse(this clsDGRegionFldsEN objDGRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objDGRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.InUse) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.InUse, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.InUse] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetErrMsg(this clsDGRegionFldsEN objDGRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conDGRegionFlds.ErrMsg);
objDGRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.ErrMsg) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetPrjId(this clsDGRegionFldsEN objDGRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conDGRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conDGRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conDGRegionFlds.PrjId);
objDGRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.PrjId) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.PrjId, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.PrjId] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetUpdUser(this clsDGRegionFldsEN objDGRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conDGRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conDGRegionFlds.UpdUser);
objDGRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.UpdUser) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.UpdUser, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.UpdUser] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetUpdDate(this clsDGRegionFldsEN objDGRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conDGRegionFlds.UpdDate);
objDGRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.UpdDate) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.UpdDate, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.UpdDate] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsDGRegionFldsEN SetMemo(this clsDGRegionFldsEN objDGRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conDGRegionFlds.Memo);
objDGRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objDGRegionFldsEN.dicFldComparisonOp.ContainsKey(conDGRegionFlds.Memo) == false)
{
objDGRegionFldsEN.dicFldComparisonOp.Add(conDGRegionFlds.Memo, strComparisonOp);
}
else
{
objDGRegionFldsEN.dicFldComparisonOp[conDGRegionFlds.Memo] = strComparisonOp;
}
}
return objDGRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsDGRegionFldsEN objDGRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.mId) == true)
{
string strComparisonOpmId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conDGRegionFlds.mId, objDGRegionFldsCond.mId, strComparisonOpmId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.RegionId, objDGRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.FldId, objDGRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.OutFldId) == true)
{
string strComparisonOpOutFldId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.OutFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.OutFldId, objDGRegionFldsCond.OutFldId, strComparisonOpOutFldId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.SortExpression) == true)
{
string strComparisonOpSortExpression = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.SortExpression];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.SortExpression, objDGRegionFldsCond.SortExpression, strComparisonOpSortExpression);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conDGRegionFlds.SeqNum, objDGRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.HeaderText) == true)
{
string strComparisonOpHeaderText = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.HeaderText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.HeaderText, objDGRegionFldsCond.HeaderText, strComparisonOpHeaderText);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.ToolTipText) == true)
{
string strComparisonOpToolTipText = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.ToolTipText];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.ToolTipText, objDGRegionFldsCond.ToolTipText, strComparisonOpToolTipText);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.CtlTypeId) == true)
{
string strComparisonOpCtlTypeId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.CtlTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.CtlTypeId, objDGRegionFldsCond.CtlTypeId, strComparisonOpCtlTypeId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.DgFuncTypeId) == true)
{
string strComparisonOpDgFuncTypeId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.DgFuncTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.DgFuncTypeId, objDGRegionFldsCond.DgFuncTypeId, strComparisonOpDgFuncTypeId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsNeedSort) == true)
{
if (objDGRegionFldsCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsNeedSort);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsDefaultSort) == true)
{
if (objDGRegionFldsCond.IsDefaultSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsDefaultSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsDefaultSort);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsTransToChkBox) == true)
{
if (objDGRegionFldsCond.IsTransToChkBox == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsTransToChkBox);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsTransToChkBox);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsVisible) == true)
{
if (objDGRegionFldsCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsVisible);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.IsFuncFld) == true)
{
if (objDGRegionFldsCond.IsFuncFld == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.IsFuncFld);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.IsFuncFld);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.InUse) == true)
{
if (objDGRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conDGRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conDGRegionFlds.InUse);
}
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.ErrMsg, objDGRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.PrjId, objDGRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.UpdUser, objDGRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.UpdDate, objDGRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objDGRegionFldsCond.IsUpdated(conDGRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objDGRegionFldsCond.dicFldComparisonOp[conDGRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conDGRegionFlds.Memo, objDGRegionFldsCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsDGRegionFldsEN objDGRegionFldsEN)
{
 if (objDGRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objDGRegionFldsEN.sfUpdFldSetStr = objDGRegionFldsEN.getsfUpdFldSetStr();
clsDGRegionFldsWApi.CheckPropertyNew(objDGRegionFldsEN); 
bool bolResult = clsDGRegionFldsWApi.UpdateRecord(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsWApi.ReFreshCache(objDGRegionFldsEN.RegionId);
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
 /// 获取唯一性条件串--DGRegionFlds(DG区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsDGRegionFldsEN objDGRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objDGRegionFldsEN == null) return "";
if (objDGRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDGRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDGRegionFldsEN.OutFldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objDGRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objDGRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDGRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objDGRegionFldsEN.OutFldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objDGRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsDGRegionFldsEN objDGRegionFldsEN)
{
try
{
clsDGRegionFldsWApi.CheckPropertyNew(objDGRegionFldsEN); 
bool bolResult = clsDGRegionFldsWApi.AddNewRecord(objDGRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsWApi.ReFreshCache(objDGRegionFldsEN.RegionId);
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
 /// <param name = "objDGRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsDGRegionFldsEN objDGRegionFldsEN, string strWhereCond)
{
try
{
clsDGRegionFldsWApi.CheckPropertyNew(objDGRegionFldsEN); 
bool bolResult = clsDGRegionFldsWApi.UpdateWithCondition(objDGRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsWApi.ReFreshCache(objDGRegionFldsEN.RegionId);
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
 /// DG区域字段(DGRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsDGRegionFldsWApi
{
private static readonly string mstrApiControllerName = "DGRegionFldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsDGRegionFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsDGRegionFldsEN objDGRegionFldsEN)
{
if (!Object.Equals(null, objDGRegionFldsEN.RegionId) && GetStrLen(objDGRegionFldsEN.RegionId) > 10)
{
 throw new Exception("字段[区域Id]的长度不能超过10!");
}
if (!Object.Equals(null, objDGRegionFldsEN.FldId) && GetStrLen(objDGRegionFldsEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objDGRegionFldsEN.OutFldId) && GetStrLen(objDGRegionFldsEN.OutFldId) > 8)
{
 throw new Exception("字段[OutFldId]的长度不能超过8!");
}
if (!Object.Equals(null, objDGRegionFldsEN.SortExpression) && GetStrLen(objDGRegionFldsEN.SortExpression) > 50)
{
 throw new Exception("字段[排序表达式]的长度不能超过50!");
}
if (!Object.Equals(null, objDGRegionFldsEN.HeaderText) && GetStrLen(objDGRegionFldsEN.HeaderText) > 100)
{
 throw new Exception("字段[列头]的长度不能超过100!");
}
if (!Object.Equals(null, objDGRegionFldsEN.ToolTipText) && GetStrLen(objDGRegionFldsEN.ToolTipText) > 150)
{
 throw new Exception("字段[提示文字]的长度不能超过150!");
}
if (!Object.Equals(null, objDGRegionFldsEN.CtlTypeId) && GetStrLen(objDGRegionFldsEN.CtlTypeId) > 2)
{
 throw new Exception("字段[控件类型号]的长度不能超过2!");
}
if (!Object.Equals(null, objDGRegionFldsEN.DgFuncTypeId) && GetStrLen(objDGRegionFldsEN.DgFuncTypeId) > 4)
{
 throw new Exception("字段[Dg功能类型Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDGRegionFldsEN.ErrMsg) && GetStrLen(objDGRegionFldsEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objDGRegionFldsEN.PrjId) && GetStrLen(objDGRegionFldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objDGRegionFldsEN.UpdUser) && GetStrLen(objDGRegionFldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objDGRegionFldsEN.UpdDate) && GetStrLen(objDGRegionFldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objDGRegionFldsEN.Memo) && GetStrLen(objDGRegionFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objDGRegionFldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsDGRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsDGRegionFldsEN objDGRegionFldsEN;
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
objDGRegionFldsEN = JsonConvert.DeserializeObject<clsDGRegionFldsEN>(strJson);
return objDGRegionFldsEN;
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
public static clsDGRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsDGRegionFldsEN objDGRegionFldsEN;
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
objDGRegionFldsEN = JsonConvert.DeserializeObject<clsDGRegionFldsEN>(strJson);
return objDGRegionFldsEN;
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
public static clsDGRegionFldsEN GetObjBymIdCache(long lngmId,string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strRegionId);
List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel =
from objDGRegionFldsEN in arrDGRegionFldsObjLstCache
where objDGRegionFldsEN.mId == lngmId 
select objDGRegionFldsEN;
if (arrDGRegionFldsObjLst_Sel.Count() == 0)
{
   clsDGRegionFldsEN obj = clsDGRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrDGRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionFldsEN>>(strJson);
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
public static List<clsDGRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionFldsEN>>(strJson);
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
public static IEnumerable<clsDGRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strRegionId);
List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsDGRegionFldsEN> arrDGRegionFldsObjLst_Sel =
from objDGRegionFldsEN in arrDGRegionFldsObjLstCache
where arrMId.Contains(objDGRegionFldsEN.mId)
select objDGRegionFldsEN;
return arrDGRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsDGRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionFldsEN>>(strJson);
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
public static List<clsDGRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionFldsEN>>(strJson);
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
public static List<clsDGRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionFldsEN>>(strJson);
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
public static List<clsDGRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsDGRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsDGRegionFldsEN>>(strJson);
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
 clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsDGRegionFldsWApi.ReFreshCache(objDGRegionFldsEN.RegionId);
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
public static int DelDGRegionFldss(List<string> arrmId)
{
string strAction = "DelDGRegionFldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsDGRegionFldsEN objDGRegionFldsEN = clsDGRegionFldsWApi.GetObjBymId(long.Parse(arrmId[0]));
clsDGRegionFldsWApi.ReFreshCache(objDGRegionFldsEN.RegionId);
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
public static int DelDGRegionFldssByCond(string strWhereCond)
{
string strAction = "DelDGRegionFldssByCond";
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
public static bool AddNewRecord(clsDGRegionFldsEN objDGRegionFldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDGRegionFldsEN>(objDGRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsWApi.ReFreshCache(objDGRegionFldsEN.RegionId);
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
 /// <param name = "objDGRegionFldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsDGRegionFldsEN objDGRegionFldsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDGRegionFldsEN>(objDGRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsDGRegionFldsWApi.ReFreshCache(objDGRegionFldsEN.RegionId);
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
public static bool UpdateRecord(clsDGRegionFldsEN objDGRegionFldsEN)
{
if (string.IsNullOrEmpty(objDGRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDGRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDGRegionFldsEN>(objDGRegionFldsEN);
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
 /// <param name = "objDGRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsDGRegionFldsEN objDGRegionFldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objDGRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDGRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objDGRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsDGRegionFldsEN>(objDGRegionFldsEN);
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
 /// <param name = "objDGRegionFldsENS">源对象</param>
 /// <param name = "objDGRegionFldsENT">目标对象</param>
 public static void CopyTo(clsDGRegionFldsEN objDGRegionFldsENS, clsDGRegionFldsEN objDGRegionFldsENT)
{
try
{
objDGRegionFldsENT.mId = objDGRegionFldsENS.mId; //mId
objDGRegionFldsENT.RegionId = objDGRegionFldsENS.RegionId; //区域Id
objDGRegionFldsENT.FldId = objDGRegionFldsENS.FldId; //字段Id
objDGRegionFldsENT.OutFldId = objDGRegionFldsENS.OutFldId; //OutFldId
objDGRegionFldsENT.SortExpression = objDGRegionFldsENS.SortExpression; //排序表达式
objDGRegionFldsENT.SeqNum = objDGRegionFldsENS.SeqNum; //字段序号
objDGRegionFldsENT.HeaderText = objDGRegionFldsENS.HeaderText; //列头
objDGRegionFldsENT.ToolTipText = objDGRegionFldsENS.ToolTipText; //提示文字
objDGRegionFldsENT.CtlTypeId = objDGRegionFldsENS.CtlTypeId; //控件类型号
objDGRegionFldsENT.DgFuncTypeId = objDGRegionFldsENS.DgFuncTypeId; //Dg功能类型Id
objDGRegionFldsENT.IsNeedSort = objDGRegionFldsENS.IsNeedSort; //是否需要排序
objDGRegionFldsENT.IsDefaultSort = objDGRegionFldsENS.IsDefaultSort; //是否默认排序
objDGRegionFldsENT.IsTransToChkBox = objDGRegionFldsENS.IsTransToChkBox; //是否转换成CheckBox
objDGRegionFldsENT.IsVisible = objDGRegionFldsENS.IsVisible; //是否显示
objDGRegionFldsENT.IsFuncFld = objDGRegionFldsENS.IsFuncFld; //是否功能字段
objDGRegionFldsENT.InUse = objDGRegionFldsENS.InUse; //是否在用
objDGRegionFldsENT.ErrMsg = objDGRegionFldsENS.ErrMsg; //错误信息
objDGRegionFldsENT.PrjId = objDGRegionFldsENS.PrjId; //工程Id
objDGRegionFldsENT.UpdUser = objDGRegionFldsENS.UpdUser; //修改者
objDGRegionFldsENT.UpdDate = objDGRegionFldsENS.UpdDate; //修改日期
objDGRegionFldsENT.Memo = objDGRegionFldsENS.Memo; //说明
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
public static DataTable ToDataTable(List<clsDGRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsDGRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsDGRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsDGRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsDGRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsDGRegionFldsEN._AttributeName)
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
public static void ReFreshThisCache(string strRegionId = "")
{


if (string.IsNullOrEmpty(strRegionId) == true)
{
  var strMsg = string.Format("参数:[strRegionId]不能为空！(In clsDGRegionFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strRegionId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strRegionId]的长度:[{0}]不正确！(clsDGRegionFldsWApi.ReFreshThisCache)", strRegionId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strRegionId);
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
public static void ReFreshCache(string strRegionId)
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsDGRegionFldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strRegionId);
CacheHelper.Remove(strKey);
clsDGRegionFldsWApi.objCommFun4WApi.ReFreshCache(strRegionId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDGRegionFldsEN> GetObjLstCache(string strRegionId)
{


if (string.IsNullOrEmpty(strRegionId) == true)
{
  var strMsg = string.Format("参数:[strRegionId]不能为空！(In clsDGRegionFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strRegionId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strRegionId]的长度:[{0}]不正确！(clsDGRegionFldsWApi.GetObjLstCache)", strRegionId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsDGRegionFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsDGRegionFldsEN._WhereFormat, strRegionId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conDGRegionFlds.RegionId, strRegionId);
}
var strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strRegionId);
List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrDGRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsDGRegionFldsEN> GetObjLstCacheFromObjLst(string strRegionId,List<clsDGRegionFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strRegionId) == true)
{
  var strMsg = string.Format("参数:[strRegionId]不能为空！(In clsDGRegionFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strRegionId.Length != 10)
{
var strMsg = string.Format("缓存分类变量:[strRegionId]的长度:[{0}]不正确！(clsDGRegionFldsWApi.GetObjLstCacheFromObjLst)", strRegionId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsDGRegionFldsEN._CurrTabName, strRegionId);
List<clsDGRegionFldsEN> arrDGRegionFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrDGRegionFldsObjLstCache = CacheHelper.Get<List<clsDGRegionFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.RegionId == strRegionId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrDGRegionFldsObjLstCache = CacheHelper.Get<List<clsDGRegionFldsEN>>(strKey);
}
return arrDGRegionFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsDGRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conDGRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conDGRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.OutFldId, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.SortExpression, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conDGRegionFlds.HeaderText, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.ToolTipText, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.CtlTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.DgFuncTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.IsNeedSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegionFlds.IsDefaultSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegionFlds.IsTransToChkBox, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegionFlds.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegionFlds.IsFuncFld, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conDGRegionFlds.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conDGRegionFlds.Memo, Type.GetType("System.String"));
foreach (clsDGRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conDGRegionFlds.mId] = objInFor[conDGRegionFlds.mId];
objDR[conDGRegionFlds.RegionId] = objInFor[conDGRegionFlds.RegionId];
objDR[conDGRegionFlds.FldId] = objInFor[conDGRegionFlds.FldId];
objDR[conDGRegionFlds.OutFldId] = objInFor[conDGRegionFlds.OutFldId];
objDR[conDGRegionFlds.SortExpression] = objInFor[conDGRegionFlds.SortExpression];
objDR[conDGRegionFlds.SeqNum] = objInFor[conDGRegionFlds.SeqNum];
objDR[conDGRegionFlds.HeaderText] = objInFor[conDGRegionFlds.HeaderText];
objDR[conDGRegionFlds.ToolTipText] = objInFor[conDGRegionFlds.ToolTipText];
objDR[conDGRegionFlds.CtlTypeId] = objInFor[conDGRegionFlds.CtlTypeId];
objDR[conDGRegionFlds.DgFuncTypeId] = objInFor[conDGRegionFlds.DgFuncTypeId];
objDR[conDGRegionFlds.IsNeedSort] = objInFor[conDGRegionFlds.IsNeedSort];
objDR[conDGRegionFlds.IsDefaultSort] = objInFor[conDGRegionFlds.IsDefaultSort];
objDR[conDGRegionFlds.IsTransToChkBox] = objInFor[conDGRegionFlds.IsTransToChkBox];
objDR[conDGRegionFlds.IsVisible] = objInFor[conDGRegionFlds.IsVisible];
objDR[conDGRegionFlds.IsFuncFld] = objInFor[conDGRegionFlds.IsFuncFld];
objDR[conDGRegionFlds.InUse] = objInFor[conDGRegionFlds.InUse];
objDR[conDGRegionFlds.ErrMsg] = objInFor[conDGRegionFlds.ErrMsg];
objDR[conDGRegionFlds.PrjId] = objInFor[conDGRegionFlds.PrjId];
objDR[conDGRegionFlds.UpdUser] = objInFor[conDGRegionFlds.UpdUser];
objDR[conDGRegionFlds.UpdDate] = objInFor[conDGRegionFlds.UpdDate];
objDR[conDGRegionFlds.Memo] = objInFor[conDGRegionFlds.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// DG区域字段(DGRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4DGRegionFlds : clsCommFun4BLV2
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
clsDGRegionFldsWApi.ReFreshThisCache(strRegionId);
}
}

}