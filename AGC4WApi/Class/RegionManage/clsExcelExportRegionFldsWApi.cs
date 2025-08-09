
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExcelExportRegionFldsWApi
 表名:ExcelExportRegionFlds(00050149)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 21:38:09
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
public static class  clsExcelExportRegionFldsWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "lngmId">mId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetmId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, long lngmId, string strComparisonOp="")
	{
objExcelExportRegionFldsEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.mId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.mId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.mId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strRegionId">区域Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetRegionId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strRegionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionId, conExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldLen(strRegionId, 10, conExcelExportRegionFlds.RegionId);
clsCheckSql.CheckFieldForeignKey(strRegionId, 10, conExcelExportRegionFlds.RegionId);
objExcelExportRegionFldsEN.RegionId = strRegionId; //区域Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.RegionId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.RegionId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.RegionId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetFldId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFldId, 8, conExcelExportRegionFlds.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, conExcelExportRegionFlds.FldId);
objExcelExportRegionFldsEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.FldId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.FldId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.FldId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strOutFldId">OutFldId</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetOutFldId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strOutFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOutFldId, 8, conExcelExportRegionFlds.OutFldId);
clsCheckSql.CheckFieldForeignKey(strOutFldId, 8, conExcelExportRegionFlds.OutFldId);
objExcelExportRegionFldsEN.OutFldId = strOutFldId; //OutFldId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.OutFldId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.OutFldId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.OutFldId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "intSeqNum">字段序号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetSeqNum(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, int intSeqNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSeqNum, conExcelExportRegionFlds.SeqNum);
objExcelExportRegionFldsEN.SeqNum = intSeqNum; //字段序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.SeqNum) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.SeqNum, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.SeqNum] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strColCaption">列标题</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetColCaption(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strColCaption, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strColCaption, 100, conExcelExportRegionFlds.ColCaption);
objExcelExportRegionFldsEN.ColCaption = strColCaption; //列标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.ColCaption) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.ColCaption, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.ColCaption] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolInUse">是否在用</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetInUse(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolInUse, string strComparisonOp="")
	{
objExcelExportRegionFldsEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.InUse) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.InUse, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.InUse] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strErrMsg">错误信息</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetErrMsg(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strErrMsg, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strErrMsg, 2000, conExcelExportRegionFlds.ErrMsg);
objExcelExportRegionFldsEN.ErrMsg = strErrMsg; //错误信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.ErrMsg) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.ErrMsg, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.ErrMsg] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetPrjId(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, conExcelExportRegionFlds.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, conExcelExportRegionFlds.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, conExcelExportRegionFlds.PrjId);
objExcelExportRegionFldsEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.PrjId) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.PrjId, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.PrjId] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdDate">修改日期</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetUpdDate(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conExcelExportRegionFlds.UpdDate);
objExcelExportRegionFldsEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.UpdDate) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.UpdDate, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.UpdDate] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strUpdUser">修改者</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetUpdUser(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, conExcelExportRegionFlds.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, conExcelExportRegionFlds.UpdUser);
objExcelExportRegionFldsEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.UpdUser) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.UpdUser, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.UpdUser] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "strMemo">说明</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetMemo(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conExcelExportRegionFlds.Memo);
objExcelExportRegionFldsEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.Memo) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.Memo, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.Memo] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsDefaultSort">是否默认排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetIsDefaultSort(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsDefaultSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultSort, conExcelExportRegionFlds.IsDefaultSort);
objExcelExportRegionFldsEN.IsDefaultSort = bolIsDefaultSort; //是否默认排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.IsDefaultSort) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.IsDefaultSort, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.IsDefaultSort] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要设置字段值的实体对象</param>
 /// <param name = "bolIsNeedSort">是否需要排序</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsExcelExportRegionFldsEN SetIsNeedSort(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, bool bolIsNeedSort, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsNeedSort, conExcelExportRegionFlds.IsNeedSort);
objExcelExportRegionFldsEN.IsNeedSort = bolIsNeedSort; //是否需要排序
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objExcelExportRegionFldsEN.dicFldComparisonOp.ContainsKey(conExcelExportRegionFlds.IsNeedSort) == false)
{
objExcelExportRegionFldsEN.dicFldComparisonOp.Add(conExcelExportRegionFlds.IsNeedSort, strComparisonOp);
}
else
{
objExcelExportRegionFldsEN.dicFldComparisonOp[conExcelExportRegionFlds.IsNeedSort] = strComparisonOp;
}
}
return objExcelExportRegionFldsEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsExcelExportRegionFldsEN objExcelExportRegionFldsCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.mId) == true)
{
string strComparisonOpmId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.mId];
strWhereCond += string.Format(" And {0} {2} {1}", conExcelExportRegionFlds.mId, objExcelExportRegionFldsCond.mId, strComparisonOpmId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.RegionId) == true)
{
string strComparisonOpRegionId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.RegionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.RegionId, objExcelExportRegionFldsCond.RegionId, strComparisonOpRegionId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.FldId) == true)
{
string strComparisonOpFldId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.FldId, objExcelExportRegionFldsCond.FldId, strComparisonOpFldId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.OutFldId) == true)
{
string strComparisonOpOutFldId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.OutFldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.OutFldId, objExcelExportRegionFldsCond.OutFldId, strComparisonOpOutFldId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.SeqNum) == true)
{
string strComparisonOpSeqNum = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.SeqNum];
strWhereCond += string.Format(" And {0} {2} {1}", conExcelExportRegionFlds.SeqNum, objExcelExportRegionFldsCond.SeqNum, strComparisonOpSeqNum);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.ColCaption) == true)
{
string strComparisonOpColCaption = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.ColCaption];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.ColCaption, objExcelExportRegionFldsCond.ColCaption, strComparisonOpColCaption);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.InUse) == true)
{
if (objExcelExportRegionFldsCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExcelExportRegionFlds.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExcelExportRegionFlds.InUse);
}
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.ErrMsg) == true)
{
string strComparisonOpErrMsg = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.ErrMsg];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.ErrMsg, objExcelExportRegionFldsCond.ErrMsg, strComparisonOpErrMsg);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.PrjId) == true)
{
string strComparisonOpPrjId = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.PrjId, objExcelExportRegionFldsCond.PrjId, strComparisonOpPrjId);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.UpdDate) == true)
{
string strComparisonOpUpdDate = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.UpdDate, objExcelExportRegionFldsCond.UpdDate, strComparisonOpUpdDate);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.UpdUser) == true)
{
string strComparisonOpUpdUser = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.UpdUser, objExcelExportRegionFldsCond.UpdUser, strComparisonOpUpdUser);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.Memo) == true)
{
string strComparisonOpMemo = objExcelExportRegionFldsCond.dicFldComparisonOp[conExcelExportRegionFlds.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conExcelExportRegionFlds.Memo, objExcelExportRegionFldsCond.Memo, strComparisonOpMemo);
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.IsDefaultSort) == true)
{
if (objExcelExportRegionFldsCond.IsDefaultSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExcelExportRegionFlds.IsDefaultSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExcelExportRegionFlds.IsDefaultSort);
}
}
if (objExcelExportRegionFldsCond.IsUpdated(conExcelExportRegionFlds.IsNeedSort) == true)
{
if (objExcelExportRegionFldsCond.IsNeedSort == true)
{
strWhereCond += string.Format(" And {0} = '1'", conExcelExportRegionFlds.IsNeedSort);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conExcelExportRegionFlds.IsNeedSort);
}
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
 if (objExcelExportRegionFldsEN.mId == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objExcelExportRegionFldsEN.sfUpdFldSetStr = objExcelExportRegionFldsEN.getsfUpdFldSetStr();
clsExcelExportRegionFldsWApi.CheckPropertyNew(objExcelExportRegionFldsEN); 
bool bolResult = clsExcelExportRegionFldsWApi.UpdateRecord(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsWApi.ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
 /// 获取唯一性条件串--ExcelExportRegionFlds(Excel导出区域字段), 即由对象中唯一性条件字段关键字与值组成的条件串
 /// 唯一性条件:RegionId_FldId_OutFldId
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objExcelExportRegionFldsEN == null) return "";
if (objExcelExportRegionFldsEN.mId == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RegionId = '{0}'", objExcelExportRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objExcelExportRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objExcelExportRegionFldsEN.OutFldId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("mId !=  {0}", objExcelExportRegionFldsEN.mId);
 sbCondition.AppendFormat(" and RegionId = '{0}'", objExcelExportRegionFldsEN.RegionId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objExcelExportRegionFldsEN.FldId);
 sbCondition.AppendFormat(" and OutFldId = '{0}'", objExcelExportRegionFldsEN.OutFldId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objExcelExportRegionFldsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
try
{
clsExcelExportRegionFldsWApi.CheckPropertyNew(objExcelExportRegionFldsEN); 
bool bolResult = clsExcelExportRegionFldsWApi.AddNewRecord(objExcelExportRegionFldsEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsWApi.ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
 /// <param name = "objExcelExportRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strWhereCond)
{
try
{
clsExcelExportRegionFldsWApi.CheckPropertyNew(objExcelExportRegionFldsEN); 
bool bolResult = clsExcelExportRegionFldsWApi.UpdateWithCondition(objExcelExportRegionFldsEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsWApi.ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
 /// Excel导出区域字段(ExcelExportRegionFlds)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsExcelExportRegionFldsWApi
{
private static readonly string mstrApiControllerName = "ExcelExportRegionFldsApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BLV2 objCommFun4WApi = null;

 public clsExcelExportRegionFldsWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
if (!Object.Equals(null, objExcelExportRegionFldsEN.RegionId) && GetStrLen(objExcelExportRegionFldsEN.RegionId) > 10)
{
 throw new Exception("字段[区域Id]的长度不能超过10!");
}
if (!Object.Equals(null, objExcelExportRegionFldsEN.FldId) && GetStrLen(objExcelExportRegionFldsEN.FldId) > 8)
{
 throw new Exception("字段[字段Id]的长度不能超过8!");
}
if (!Object.Equals(null, objExcelExportRegionFldsEN.OutFldId) && GetStrLen(objExcelExportRegionFldsEN.OutFldId) > 8)
{
 throw new Exception("字段[OutFldId]的长度不能超过8!");
}
if (!Object.Equals(null, objExcelExportRegionFldsEN.ColCaption) && GetStrLen(objExcelExportRegionFldsEN.ColCaption) > 100)
{
 throw new Exception("字段[列标题]的长度不能超过100!");
}
if (!Object.Equals(null, objExcelExportRegionFldsEN.ErrMsg) && GetStrLen(objExcelExportRegionFldsEN.ErrMsg) > 2000)
{
 throw new Exception("字段[错误信息]的长度不能超过2000!");
}
if (!Object.Equals(null, objExcelExportRegionFldsEN.PrjId) && GetStrLen(objExcelExportRegionFldsEN.PrjId) > 4)
{
 throw new Exception("字段[工程Id]的长度不能超过4!");
}
if (!Object.Equals(null, objExcelExportRegionFldsEN.UpdDate) && GetStrLen(objExcelExportRegionFldsEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objExcelExportRegionFldsEN.UpdUser) && GetStrLen(objExcelExportRegionFldsEN.UpdUser) > 20)
{
 throw new Exception("字段[修改者]的长度不能超过20!");
}
if (!Object.Equals(null, objExcelExportRegionFldsEN.Memo) && GetStrLen(objExcelExportRegionFldsEN.Memo) > 1000)
{
 throw new Exception("字段[说明]的长度不能超过1000!");
}
 objExcelExportRegionFldsEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsExcelExportRegionFldsEN GetObjBymId(long lngmId)
{
if (lngmId == 0) return null;
string strAction = "GetObjBymId";
clsExcelExportRegionFldsEN objExcelExportRegionFldsEN;
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
objExcelExportRegionFldsEN = JsonConvert.DeserializeObject<clsExcelExportRegionFldsEN>(strJson);
return objExcelExportRegionFldsEN;
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
public static clsExcelExportRegionFldsEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsExcelExportRegionFldsEN objExcelExportRegionFldsEN;
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
objExcelExportRegionFldsEN = JsonConvert.DeserializeObject<clsExcelExportRegionFldsEN>(strJson);
return objExcelExportRegionFldsEN;
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
public static clsExcelExportRegionFldsEN GetObjBymIdCache(long lngmId,string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel =
from objExcelExportRegionFldsEN in arrExcelExportRegionFldsObjLstCache
where objExcelExportRegionFldsEN.mId == lngmId 
select objExcelExportRegionFldsEN;
if (arrExcelExportRegionFldsObjLst_Sel.Count() == 0)
{
   clsExcelExportRegionFldsEN obj = clsExcelExportRegionFldsWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrExcelExportRegionFldsObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetObjLst(string strWhereCond)
{
 List<clsExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExcelExportRegionFldsEN>>(strJson);
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExcelExportRegionFldsEN>>(strJson);
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
public static IEnumerable<clsExcelExportRegionFldsEN> GetObjLstByMIdLstCache(List<long> arrMId, string strRegionId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLstCache = GetObjLstCache(strRegionId);
IEnumerable <clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLst_Sel =
from objExcelExportRegionFldsEN in arrExcelExportRegionFldsObjLstCache
where arrMId.Contains(objExcelExportRegionFldsEN.mId)
select objExcelExportRegionFldsEN;
return arrExcelExportRegionFldsObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExcelExportRegionFldsEN>>(strJson);
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExcelExportRegionFldsEN>>(strJson);
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExcelExportRegionFldsEN>>(strJson);
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
public static List<clsExcelExportRegionFldsEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsExcelExportRegionFldsEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsExcelExportRegionFldsEN>>(strJson);
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
 clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsWApi.GetObjBymId(lngmId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngmId.ToString(), out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
clsExcelExportRegionFldsWApi.ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
public static int DelExcelExportRegionFldss(List<string> arrmId)
{
string strAction = "DelExcelExportRegionFldss";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrmId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
 clsExcelExportRegionFldsEN objExcelExportRegionFldsEN = clsExcelExportRegionFldsWApi.GetObjBymId(long.Parse(arrmId[0]));
clsExcelExportRegionFldsWApi.ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
public static int DelExcelExportRegionFldssByCond(string strWhereCond)
{
string strAction = "DelExcelExportRegionFldssByCond";
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
public static bool AddNewRecord(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
string strAction = "AddNewRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsExcelExportRegionFldsEN>(objExcelExportRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsWApi.ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
 /// <param name = "objExcelExportRegionFldsEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
string strAction = "AddNewRecordWithReturnKey";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsExcelExportRegionFldsEN>(objExcelExportRegionFldsEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExcelExportRegionFldsWApi.ReFreshCache(objExcelExportRegionFldsEN.PrjId);
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
public static bool UpdateRecord(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN)
{
if (string.IsNullOrEmpty(objExcelExportRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objExcelExportRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsExcelExportRegionFldsEN>(objExcelExportRegionFldsEN);
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
 /// <param name = "objExcelExportRegionFldsEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsExcelExportRegionFldsEN objExcelExportRegionFldsEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objExcelExportRegionFldsEN.sfUpdFldSetStr) == true)
{
string strMsg = string.Format("修改时,修改标志串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objExcelExportRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时,条件串为空,请联系管理员.对象关键字:{0}.(from {1}).",
objExcelExportRegionFldsEN.mId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsExcelExportRegionFldsEN>(objExcelExportRegionFldsEN);
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
 /// <param name = "objExcelExportRegionFldsENS">源对象</param>
 /// <param name = "objExcelExportRegionFldsENT">目标对象</param>
 public static void CopyTo(clsExcelExportRegionFldsEN objExcelExportRegionFldsENS, clsExcelExportRegionFldsEN objExcelExportRegionFldsENT)
{
try
{
objExcelExportRegionFldsENT.mId = objExcelExportRegionFldsENS.mId; //mId
objExcelExportRegionFldsENT.RegionId = objExcelExportRegionFldsENS.RegionId; //区域Id
objExcelExportRegionFldsENT.FldId = objExcelExportRegionFldsENS.FldId; //字段Id
objExcelExportRegionFldsENT.OutFldId = objExcelExportRegionFldsENS.OutFldId; //OutFldId
objExcelExportRegionFldsENT.SeqNum = objExcelExportRegionFldsENS.SeqNum; //字段序号
objExcelExportRegionFldsENT.ColCaption = objExcelExportRegionFldsENS.ColCaption; //列标题
objExcelExportRegionFldsENT.InUse = objExcelExportRegionFldsENS.InUse; //是否在用
objExcelExportRegionFldsENT.ErrMsg = objExcelExportRegionFldsENS.ErrMsg; //错误信息
objExcelExportRegionFldsENT.PrjId = objExcelExportRegionFldsENS.PrjId; //工程Id
objExcelExportRegionFldsENT.UpdDate = objExcelExportRegionFldsENS.UpdDate; //修改日期
objExcelExportRegionFldsENT.UpdUser = objExcelExportRegionFldsENS.UpdUser; //修改者
objExcelExportRegionFldsENT.Memo = objExcelExportRegionFldsENS.Memo; //说明
objExcelExportRegionFldsENT.IsDefaultSort = objExcelExportRegionFldsENS.IsDefaultSort; //是否默认排序
objExcelExportRegionFldsENT.IsNeedSort = objExcelExportRegionFldsENS.IsNeedSort; //是否需要排序
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
public static DataTable ToDataTable(List<clsExcelExportRegionFldsEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsExcelExportRegionFldsEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsExcelExportRegionFldsEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsExcelExportRegionFldsEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsExcelExportRegionFldsEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsExcelExportRegionFldsEN._AttributeName)
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
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsExcelExportRegionFldsWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsExcelExportRegionFldsWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
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
if (clsExcelExportRegionFldsWApi.objCommFun4WApi != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsExcelExportRegionFldsWApi.objCommFun4WApi.ReFreshCache(strPrjId.ToString());
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetObjLstCache(string strRegionId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsExcelExportRegionFldsWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsExcelExportRegionFldsWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsExcelExportRegionFldsEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsExcelExportRegionFldsEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",conExcelExportRegionFlds.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrExcelExportRegionFldsObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsExcelExportRegionFldsEN> GetObjLstCacheFromObjLst(string strRegionId,List<clsExcelExportRegionFldsEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsExcelExportRegionFldsWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsExcelExportRegionFldsWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsExcelExportRegionFldsEN._CurrTabName, strPrjId);
List<clsExcelExportRegionFldsEN> arrExcelExportRegionFldsObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrExcelExportRegionFldsObjLstCache = CacheHelper.Get<List<clsExcelExportRegionFldsEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrExcelExportRegionFldsObjLstCache = CacheHelper.Get<List<clsExcelExportRegionFldsEN>>(strKey);
}
return arrExcelExportRegionFldsObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsExcelExportRegionFldsEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conExcelExportRegionFlds.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(conExcelExportRegionFlds.RegionId, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.FldId, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.OutFldId, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.SeqNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conExcelExportRegionFlds.ColCaption, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.InUse, Type.GetType("System.Boolean"));
objDT.Columns.Add(conExcelExportRegionFlds.ErrMsg, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.Memo, Type.GetType("System.String"));
objDT.Columns.Add(conExcelExportRegionFlds.IsDefaultSort, Type.GetType("System.Boolean"));
objDT.Columns.Add(conExcelExportRegionFlds.IsNeedSort, Type.GetType("System.Boolean"));
foreach (clsExcelExportRegionFldsEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conExcelExportRegionFlds.mId] = objInFor[conExcelExportRegionFlds.mId];
objDR[conExcelExportRegionFlds.RegionId] = objInFor[conExcelExportRegionFlds.RegionId];
objDR[conExcelExportRegionFlds.FldId] = objInFor[conExcelExportRegionFlds.FldId];
objDR[conExcelExportRegionFlds.OutFldId] = objInFor[conExcelExportRegionFlds.OutFldId];
objDR[conExcelExportRegionFlds.SeqNum] = objInFor[conExcelExportRegionFlds.SeqNum];
objDR[conExcelExportRegionFlds.ColCaption] = objInFor[conExcelExportRegionFlds.ColCaption];
objDR[conExcelExportRegionFlds.InUse] = objInFor[conExcelExportRegionFlds.InUse];
objDR[conExcelExportRegionFlds.ErrMsg] = objInFor[conExcelExportRegionFlds.ErrMsg];
objDR[conExcelExportRegionFlds.PrjId] = objInFor[conExcelExportRegionFlds.PrjId];
objDR[conExcelExportRegionFlds.UpdDate] = objInFor[conExcelExportRegionFlds.UpdDate];
objDR[conExcelExportRegionFlds.UpdUser] = objInFor[conExcelExportRegionFlds.UpdUser];
objDR[conExcelExportRegionFlds.Memo] = objInFor[conExcelExportRegionFlds.Memo];
objDR[conExcelExportRegionFlds.IsDefaultSort] = objInFor[conExcelExportRegionFlds.IsDefaultSort];
objDR[conExcelExportRegionFlds.IsNeedSort] = objInFor[conExcelExportRegionFlds.IsNeedSort];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// Excel导出区域字段(ExcelExportRegionFlds)
 /// 数据源类型:表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class  clsCommFun4WA4ExcelExportRegionFlds : clsCommFun4BLV2
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
clsExcelExportRegionFldsWApi.ReFreshThisCache(strRegionId);
}
}

}