
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFrontAndBack4AppTypeBL
 表名:vFrontAndBack4AppType(00050424)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:16
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvFrontAndBack4AppTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFrontAndBack4AppTypeEN GetObj(this K_mId_vFrontAndBack4AppType myKey)
{
clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = clsvFrontAndBack4AppTypeBL.vFrontAndBack4AppTypeDA.GetObjBymId(myKey.Value);
return objvFrontAndBack4AppTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetmId(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, long lngmId, string strComparisonOp="")
	{
objvFrontAndBack4AppTypeEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.mId) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.mId, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.mId] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetOrderNum(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, int intOrderNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intOrderNum, convFrontAndBack4AppType.OrderNum);
objvFrontAndBack4AppTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.OrderNum) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.OrderNum, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.OrderNum] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetAppTypeId4Front(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, int? intAppTypeId4Front, string strComparisonOp="")
	{
objvFrontAndBack4AppTypeEN.AppTypeId4Front = intAppTypeId4Front; //应用类型Id4Front
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.AppTypeId4Front) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.AppTypeId4Front, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.AppTypeId4Front] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetApplTypeName4Front(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strApplTypeName4Front, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplTypeName4Front, 30, convFrontAndBack4AppType.ApplTypeName4Front);
}
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = strApplTypeName4Front; //ApplTypeName4Front
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.ApplTypeName4Front) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.ApplTypeName4Front, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.ApplTypeName4Front] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetIsVisible(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, bool bolIsVisible, string strComparisonOp="")
	{
objvFrontAndBack4AppTypeEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.IsVisible) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.IsVisible, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.IsVisible] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetAppTypeId4Back(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, int? intAppTypeId4Back, string strComparisonOp="")
	{
objvFrontAndBack4AppTypeEN.AppTypeId4Back = intAppTypeId4Back; //应用类型Id4Back
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.AppTypeId4Back) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.AppTypeId4Back, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.AppTypeId4Back] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetApplTypeName4Back(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strApplTypeName4Back, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strApplTypeName4Back, 30, convFrontAndBack4AppType.ApplTypeName4Back);
}
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = strApplTypeName4Back; //ApplTypeName4Back
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.ApplTypeName4Back) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.ApplTypeName4Back, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.ApplTypeName4Back] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetUpdDate(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFrontAndBack4AppType.UpdDate);
}
objvFrontAndBack4AppTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.UpdDate) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.UpdDate, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.UpdDate] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetUpdUser(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFrontAndBack4AppType.UpdUser);
}
objvFrontAndBack4AppTypeEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.UpdUser) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.UpdUser, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.UpdUser] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFrontAndBack4AppTypeEN SetMemo(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFrontAndBack4AppType.Memo);
}
objvFrontAndBack4AppTypeEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFrontAndBack4AppTypeEN.dicFldComparisonOp.ContainsKey(convFrontAndBack4AppType.Memo) == false)
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp.Add(convFrontAndBack4AppType.Memo, strComparisonOp);
}
else
{
objvFrontAndBack4AppTypeEN.dicFldComparisonOp[convFrontAndBack4AppType.Memo] = strComparisonOp;
}
}
return objvFrontAndBack4AppTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objvFrontAndBack4AppTypeENT">目标对象</param>
 public static void CopyTo(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENS, clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENT)
{
try
{
objvFrontAndBack4AppTypeENT.mId = objvFrontAndBack4AppTypeENS.mId; //mId
objvFrontAndBack4AppTypeENT.OrderNum = objvFrontAndBack4AppTypeENS.OrderNum; //序号
objvFrontAndBack4AppTypeENT.AppTypeId4Front = objvFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objvFrontAndBack4AppTypeENT.ApplTypeName4Front = objvFrontAndBack4AppTypeENS.ApplTypeName4Front; //ApplTypeName4Front
objvFrontAndBack4AppTypeENT.IsVisible = objvFrontAndBack4AppTypeENS.IsVisible; //是否显示
objvFrontAndBack4AppTypeENT.AppTypeId4Back = objvFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objvFrontAndBack4AppTypeENT.ApplTypeName4Back = objvFrontAndBack4AppTypeENS.ApplTypeName4Back; //ApplTypeName4Back
objvFrontAndBack4AppTypeENT.UpdDate = objvFrontAndBack4AppTypeENS.UpdDate; //修改日期
objvFrontAndBack4AppTypeENT.UpdUser = objvFrontAndBack4AppTypeENS.UpdUser; //修改者
objvFrontAndBack4AppTypeENT.Memo = objvFrontAndBack4AppTypeENS.Memo; //说明
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
 /// <param name = "objvFrontAndBack4AppTypeENS">源对象</param>
 /// <returns>目标对象=>clsvFrontAndBack4AppTypeEN:objvFrontAndBack4AppTypeENT</returns>
 public static clsvFrontAndBack4AppTypeEN CopyTo(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENS)
{
try
{
 clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENT = new clsvFrontAndBack4AppTypeEN()
{
mId = objvFrontAndBack4AppTypeENS.mId, //mId
OrderNum = objvFrontAndBack4AppTypeENS.OrderNum, //序号
AppTypeId4Front = objvFrontAndBack4AppTypeENS.AppTypeId4Front, //应用类型Id4Front
ApplTypeName4Front = objvFrontAndBack4AppTypeENS.ApplTypeName4Front, //ApplTypeName4Front
IsVisible = objvFrontAndBack4AppTypeENS.IsVisible, //是否显示
AppTypeId4Back = objvFrontAndBack4AppTypeENS.AppTypeId4Back, //应用类型Id4Back
ApplTypeName4Back = objvFrontAndBack4AppTypeENS.ApplTypeName4Back, //ApplTypeName4Back
UpdDate = objvFrontAndBack4AppTypeENS.UpdDate, //修改日期
UpdUser = objvFrontAndBack4AppTypeENS.UpdUser, //修改者
Memo = objvFrontAndBack4AppTypeENS.Memo, //说明
};
 return objvFrontAndBack4AppTypeENT;
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
public static void CheckProperty4Condition(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN)
{
 clsvFrontAndBack4AppTypeBL.vFrontAndBack4AppTypeDA.CheckProperty4Condition(objvFrontAndBack4AppTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.mId) == true)
{
string strComparisonOpmId = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convFrontAndBack4AppType.mId, objvFrontAndBack4AppTypeCond.mId, strComparisonOpmId);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.OrderNum) == true)
{
string strComparisonOpOrderNum = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFrontAndBack4AppType.OrderNum, objvFrontAndBack4AppTypeCond.OrderNum, strComparisonOpOrderNum);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.AppTypeId4Front) == true)
{
string strComparisonOpAppTypeId4Front = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.AppTypeId4Front];
strWhereCond += string.Format(" And {0} {2} {1}", convFrontAndBack4AppType.AppTypeId4Front, objvFrontAndBack4AppTypeCond.AppTypeId4Front, strComparisonOpAppTypeId4Front);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.ApplTypeName4Front) == true)
{
string strComparisonOpApplTypeName4Front = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.ApplTypeName4Front];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.ApplTypeName4Front, objvFrontAndBack4AppTypeCond.ApplTypeName4Front, strComparisonOpApplTypeName4Front);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.IsVisible) == true)
{
if (objvFrontAndBack4AppTypeCond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convFrontAndBack4AppType.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convFrontAndBack4AppType.IsVisible);
}
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.AppTypeId4Back) == true)
{
string strComparisonOpAppTypeId4Back = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.AppTypeId4Back];
strWhereCond += string.Format(" And {0} {2} {1}", convFrontAndBack4AppType.AppTypeId4Back, objvFrontAndBack4AppTypeCond.AppTypeId4Back, strComparisonOpAppTypeId4Back);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.ApplTypeName4Back) == true)
{
string strComparisonOpApplTypeName4Back = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.ApplTypeName4Back];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.ApplTypeName4Back, objvFrontAndBack4AppTypeCond.ApplTypeName4Back, strComparisonOpApplTypeName4Back);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.UpdDate, objvFrontAndBack4AppTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.UpdUser, objvFrontAndBack4AppTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFrontAndBack4AppTypeCond.IsUpdated(convFrontAndBack4AppType.Memo) == true)
{
string strComparisonOpMemo = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[convFrontAndBack4AppType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFrontAndBack4AppType.Memo, objvFrontAndBack4AppTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFrontAndBack4AppType
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v应用类型的前后台关系(vFrontAndBack4AppType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFrontAndBack4AppTypeBL
{
public static RelatedActions_vFrontAndBack4AppType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFrontAndBack4AppTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFrontAndBack4AppTypeDA vFrontAndBack4AppTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFrontAndBack4AppTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFrontAndBack4AppTypeBL()
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
if (string.IsNullOrEmpty(clsvFrontAndBack4AppTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFrontAndBack4AppTypeEN._ConnectString);
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
public static DataTable GetDataTable_vFrontAndBack4AppType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFrontAndBack4AppTypeDA.GetDataTable_vFrontAndBack4AppType(strWhereCond);
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
objDT = vFrontAndBack4AppTypeDA.GetDataTable(strWhereCond);
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
objDT = vFrontAndBack4AppTypeDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFrontAndBack4AppTypeDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFrontAndBack4AppTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFrontAndBack4AppTypeDA.GetDataTable_Top(objTopPara);
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
objDT = vFrontAndBack4AppTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFrontAndBack4AppTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFrontAndBack4AppTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
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
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFrontAndBack4AppTypeEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvFrontAndBack4AppTypeEN._CurrTabName);
List<clsvFrontAndBack4AppTypeEN> arrvFrontAndBack4AppTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvFrontAndBack4AppTypeEN> arrvFrontAndBack4AppTypeObjLst_Sel =
arrvFrontAndBack4AppTypeObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvFrontAndBack4AppTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFrontAndBack4AppTypeEN> GetObjLst(string strWhereCond)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFrontAndBack4AppTypeEN> GetSubObjLstCache(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeCond)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFrontAndBack4AppTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFrontAndBack4AppType._AttributeName)
{
if (objvFrontAndBack4AppTypeCond.IsUpdated(strFldName) == false) continue;
if (objvFrontAndBack4AppTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFrontAndBack4AppTypeCond[strFldName].ToString());
}
else
{
if (objvFrontAndBack4AppTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFrontAndBack4AppTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFrontAndBack4AppTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFrontAndBack4AppTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFrontAndBack4AppTypeCond[strFldName]));
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
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
List<clsvFrontAndBack4AppTypeEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFrontAndBack4AppTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFrontAndBack4AppTypeEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFrontAndBack4AppTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
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
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
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
public static List<clsvFrontAndBack4AppTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
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
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFrontAndBack4AppTypeEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFrontAndBack4AppType(ref clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN)
{
bool bolResult = vFrontAndBack4AppTypeDA.GetvFrontAndBack4AppType(ref objvFrontAndBack4AppTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFrontAndBack4AppTypeEN GetObjBymId(long lngmId)
{
clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = vFrontAndBack4AppTypeDA.GetObjBymId(lngmId);
return objvFrontAndBack4AppTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFrontAndBack4AppTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = vFrontAndBack4AppTypeDA.GetFirstObj(strWhereCond);
 return objvFrontAndBack4AppTypeEN;
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
public static clsvFrontAndBack4AppTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = vFrontAndBack4AppTypeDA.GetObjByDataRow(objRow);
 return objvFrontAndBack4AppTypeEN;
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
public static clsvFrontAndBack4AppTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = vFrontAndBack4AppTypeDA.GetObjByDataRow(objRow);
 return objvFrontAndBack4AppTypeEN;
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
 /// <param name = "lstvFrontAndBack4AppTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFrontAndBack4AppTypeEN GetObjBymIdFromList(long lngmId, List<clsvFrontAndBack4AppTypeEN> lstvFrontAndBack4AppTypeObjLst)
{
foreach (clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN in lstvFrontAndBack4AppTypeObjLst)
{
if (objvFrontAndBack4AppTypeEN.mId == lngmId)
{
return objvFrontAndBack4AppTypeEN;
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
 lngmId = new clsvFrontAndBack4AppTypeDA().GetFirstID(strWhereCond);
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
 arrList = vFrontAndBack4AppTypeDA.GetID(strWhereCond);
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
bool bolIsExist = vFrontAndBack4AppTypeDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFrontAndBack4AppTypeDA.IsExist(lngmId);
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
 bolIsExist = clsvFrontAndBack4AppTypeDA.IsExistTable();
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
 bolIsExist = vFrontAndBack4AppTypeDA.IsExistTable(strTabName);
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
 /// <param name = "objvFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objvFrontAndBack4AppTypeENT">目标对象</param>
 public static void CopyTo(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENS, clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENT)
{
try
{
objvFrontAndBack4AppTypeENT.mId = objvFrontAndBack4AppTypeENS.mId; //mId
objvFrontAndBack4AppTypeENT.OrderNum = objvFrontAndBack4AppTypeENS.OrderNum; //序号
objvFrontAndBack4AppTypeENT.AppTypeId4Front = objvFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objvFrontAndBack4AppTypeENT.ApplTypeName4Front = objvFrontAndBack4AppTypeENS.ApplTypeName4Front; //ApplTypeName4Front
objvFrontAndBack4AppTypeENT.IsVisible = objvFrontAndBack4AppTypeENS.IsVisible; //是否显示
objvFrontAndBack4AppTypeENT.AppTypeId4Back = objvFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objvFrontAndBack4AppTypeENT.ApplTypeName4Back = objvFrontAndBack4AppTypeENS.ApplTypeName4Back; //ApplTypeName4Back
objvFrontAndBack4AppTypeENT.UpdDate = objvFrontAndBack4AppTypeENS.UpdDate; //修改日期
objvFrontAndBack4AppTypeENT.UpdUser = objvFrontAndBack4AppTypeENS.UpdUser; //修改者
objvFrontAndBack4AppTypeENT.Memo = objvFrontAndBack4AppTypeENS.Memo; //说明
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
 /// <param name = "objvFrontAndBack4AppTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN)
{
try
{
objvFrontAndBack4AppTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFrontAndBack4AppTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFrontAndBack4AppType.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.mId = objvFrontAndBack4AppTypeEN.mId; //mId
}
if (arrFldSet.Contains(convFrontAndBack4AppType.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.OrderNum = objvFrontAndBack4AppTypeEN.OrderNum; //序号
}
if (arrFldSet.Contains(convFrontAndBack4AppType.AppTypeId4Front, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objvFrontAndBack4AppTypeEN.AppTypeId4Front; //应用类型Id4Front
}
if (arrFldSet.Contains(convFrontAndBack4AppType.ApplTypeName4Front, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objvFrontAndBack4AppTypeEN.ApplTypeName4Front == "[null]" ? null :  objvFrontAndBack4AppTypeEN.ApplTypeName4Front; //ApplTypeName4Front
}
if (arrFldSet.Contains(convFrontAndBack4AppType.IsVisible, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.IsVisible = objvFrontAndBack4AppTypeEN.IsVisible; //是否显示
}
if (arrFldSet.Contains(convFrontAndBack4AppType.AppTypeId4Back, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objvFrontAndBack4AppTypeEN.AppTypeId4Back; //应用类型Id4Back
}
if (arrFldSet.Contains(convFrontAndBack4AppType.ApplTypeName4Back, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objvFrontAndBack4AppTypeEN.ApplTypeName4Back == "[null]" ? null :  objvFrontAndBack4AppTypeEN.ApplTypeName4Back; //ApplTypeName4Back
}
if (arrFldSet.Contains(convFrontAndBack4AppType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.UpdDate = objvFrontAndBack4AppTypeEN.UpdDate == "[null]" ? null :  objvFrontAndBack4AppTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFrontAndBack4AppType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.UpdUser = objvFrontAndBack4AppTypeEN.UpdUser == "[null]" ? null :  objvFrontAndBack4AppTypeEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFrontAndBack4AppType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFrontAndBack4AppTypeEN.Memo = objvFrontAndBack4AppTypeEN.Memo == "[null]" ? null :  objvFrontAndBack4AppTypeEN.Memo; //说明
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
 /// <param name = "objvFrontAndBack4AppTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN)
{
try
{
if (objvFrontAndBack4AppTypeEN.ApplTypeName4Front == "[null]") objvFrontAndBack4AppTypeEN.ApplTypeName4Front = null; //ApplTypeName4Front
if (objvFrontAndBack4AppTypeEN.ApplTypeName4Back == "[null]") objvFrontAndBack4AppTypeEN.ApplTypeName4Back = null; //ApplTypeName4Back
if (objvFrontAndBack4AppTypeEN.UpdDate == "[null]") objvFrontAndBack4AppTypeEN.UpdDate = null; //修改日期
if (objvFrontAndBack4AppTypeEN.UpdUser == "[null]") objvFrontAndBack4AppTypeEN.UpdUser = null; //修改者
if (objvFrontAndBack4AppTypeEN.Memo == "[null]") objvFrontAndBack4AppTypeEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN)
{
 vFrontAndBack4AppTypeDA.CheckProperty4Condition(objvFrontAndBack4AppTypeEN);
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
if (clsApplicationTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsApplicationTypeBL没有刷新缓存机制(clsApplicationTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFrontAndBack4AppTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFrontAndBack4AppTypeBL没有刷新缓存机制(clsFrontAndBack4AppTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvFrontAndBack4AppTypeObjLstCache == null)
//{
//arrvFrontAndBack4AppTypeObjLstCache = vFrontAndBack4AppTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFrontAndBack4AppTypeEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFrontAndBack4AppTypeEN._CurrTabName);
List<clsvFrontAndBack4AppTypeEN> arrvFrontAndBack4AppTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvFrontAndBack4AppTypeEN> arrvFrontAndBack4AppTypeObjLst_Sel =
arrvFrontAndBack4AppTypeObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvFrontAndBack4AppTypeObjLst_Sel.Count() == 0)
{
   clsvFrontAndBack4AppTypeEN obj = clsvFrontAndBack4AppTypeBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFrontAndBack4AppTypeObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFrontAndBack4AppTypeEN> GetAllvFrontAndBack4AppTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvFrontAndBack4AppTypeEN> arrvFrontAndBack4AppTypeObjLstCache = GetObjLstCache(); 
return arrvFrontAndBack4AppTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFrontAndBack4AppTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFrontAndBack4AppTypeEN._CurrTabName);
List<clsvFrontAndBack4AppTypeEN> arrvFrontAndBack4AppTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFrontAndBack4AppTypeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvFrontAndBack4AppTypeEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFrontAndBack4AppTypeEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFrontAndBack4AppTypeEN._RefreshTimeLst.Count == 0) return "";
return clsvFrontAndBack4AppTypeEN._RefreshTimeLst[clsvFrontAndBack4AppTypeEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convFrontAndBack4AppType.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFrontAndBack4AppType._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFrontAndBack4AppType._AttributeName));
throw new Exception(strMsg);
}
var objvFrontAndBack4AppType = clsvFrontAndBack4AppTypeBL.GetObjBymIdCache(lngmId);
if (objvFrontAndBack4AppType == null) return "";
return objvFrontAndBack4AppType[strOutFldName].ToString();
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
int intRecCount = clsvFrontAndBack4AppTypeDA.GetRecCount(strTabName);
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
int intRecCount = clsvFrontAndBack4AppTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFrontAndBack4AppTypeDA.GetRecCount();
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
int intRecCount = clsvFrontAndBack4AppTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeCond)
{
List<clsvFrontAndBack4AppTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFrontAndBack4AppTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFrontAndBack4AppType._AttributeName)
{
if (objvFrontAndBack4AppTypeCond.IsUpdated(strFldName) == false) continue;
if (objvFrontAndBack4AppTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFrontAndBack4AppTypeCond[strFldName].ToString());
}
else
{
if (objvFrontAndBack4AppTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFrontAndBack4AppTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFrontAndBack4AppTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFrontAndBack4AppTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFrontAndBack4AppTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFrontAndBack4AppTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFrontAndBack4AppTypeCond[strFldName]));
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
 List<string> arrList = clsvFrontAndBack4AppTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFrontAndBack4AppTypeDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFrontAndBack4AppTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}