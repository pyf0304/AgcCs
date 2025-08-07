
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNode_SimWApi
 表名:vDataNode_Sim(00050592)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:38:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
public static class  clsvDataNode_SimWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "lngDataNodeId">数据结点Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetDataNodeId(this clsvDataNode_SimEN objvDataNode_SimEN, long lngDataNodeId, string strComparisonOp="")
	{
objvDataNode_SimEN.DataNodeId = lngDataNodeId; //数据结点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.DataNodeId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.DataNodeId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.DataNodeId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeName">数据结点名</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetDataNodeName(this clsvDataNode_SimEN objvDataNode_SimEN, string strDataNodeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDataNodeName, 100, convDataNode_Sim.DataNodeName);
objvDataNode_SimEN.DataNodeName = strDataNodeName; //数据结点名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.DataNodeName) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.DataNodeName, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.DataNodeName] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strTabId">表ID</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetTabId(this clsvDataNode_SimEN objvDataNode_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convDataNode_Sim.TabId);
clsCheckSql.CheckFieldLen(strTabId, 8, convDataNode_Sim.TabId);
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convDataNode_Sim.TabId);
objvDataNode_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.TabId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.TabId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.TabId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strFldId">字段Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetFldId(this clsvDataNode_SimEN objvDataNode_SimEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convDataNode_Sim.FldId);
clsCheckSql.CheckFieldLen(strFldId, 8, convDataNode_Sim.FldId);
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convDataNode_Sim.FldId);
objvDataNode_SimEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.FldId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.FldId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.FldId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strKeyFldLst">关键字段Id列表</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetKeyFldLst(this clsvDataNode_SimEN objvDataNode_SimEN, string strKeyFldLst, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyFldLst, 100, convDataNode_Sim.KeyFldLst);
objvDataNode_SimEN.KeyFldLst = strKeyFldLst; //关键字段Id列表
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.KeyFldLst) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.KeyFldLst, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.KeyFldLst] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strDataNodeTypeId">数据结点类型Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetDataNodeTypeId(this clsvDataNode_SimEN objvDataNode_SimEN, string strDataNodeTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDataNodeTypeId, convDataNode_Sim.DataNodeTypeId);
clsCheckSql.CheckFieldLen(strDataNodeTypeId, 2, convDataNode_Sim.DataNodeTypeId);
clsCheckSql.CheckFieldForeignKey(strDataNodeTypeId, 2, convDataNode_Sim.DataNodeTypeId);
objvDataNode_SimEN.DataNodeTypeId = strDataNodeTypeId; //数据结点类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.DataNodeTypeId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.DataNodeTypeId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.DataNodeTypeId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intVersionNo">版本号</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetVersionNo(this clsvDataNode_SimEN objvDataNode_SimEN, int intVersionNo, string strComparisonOp="")
	{
objvDataNode_SimEN.VersionNo = intVersionNo; //版本号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.VersionNo) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.VersionNo, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.VersionNo] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strPrjId">工程Id</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetPrjId(this clsvDataNode_SimEN objvDataNode_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convDataNode_Sim.PrjId);
clsCheckSql.CheckFieldLen(strPrjId, 4, convDataNode_Sim.PrjId);
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convDataNode_Sim.PrjId);
objvDataNode_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.PrjId) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.PrjId, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.PrjId] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "dblPosX">位置X</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetPosX(this clsvDataNode_SimEN objvDataNode_SimEN, double dblPosX, string strComparisonOp="")
	{
objvDataNode_SimEN.PosX = dblPosX; //位置X
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.PosX) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.PosX, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.PosX] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "dblPosY">位置Y</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetPosY(this clsvDataNode_SimEN objvDataNode_SimEN, double dblPosY, string strComparisonOp="")
	{
objvDataNode_SimEN.PosY = dblPosY; //位置Y
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.PosY) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.PosY, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.PosY] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "intUsedTimes">使用次数</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDataNode_SimEN SetUsedTimes(this clsvDataNode_SimEN objvDataNode_SimEN, int intUsedTimes, string strComparisonOp="")
	{
objvDataNode_SimEN.UsedTimes = intUsedTimes; //使用次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDataNode_SimEN.dicFldComparisonOp.ContainsKey(convDataNode_Sim.UsedTimes) == false)
{
objvDataNode_SimEN.dicFldComparisonOp.Add(convDataNode_Sim.UsedTimes, strComparisonOp);
}
else
{
objvDataNode_SimEN.dicFldComparisonOp[convDataNode_Sim.UsedTimes] = strComparisonOp;
}
}
return objvDataNode_SimEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDataNode_SimEN objvDataNode_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.DataNodeId) == true)
{
string strComparisonOpDataNodeId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.DataNodeId];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.DataNodeId, objvDataNode_SimCond.DataNodeId, strComparisonOpDataNodeId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.DataNodeName) == true)
{
string strComparisonOpDataNodeName = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.DataNodeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.DataNodeName, objvDataNode_SimCond.DataNodeName, strComparisonOpDataNodeName);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.TabId) == true)
{
string strComparisonOpTabId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.TabId, objvDataNode_SimCond.TabId, strComparisonOpTabId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.FldId) == true)
{
string strComparisonOpFldId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.FldId, objvDataNode_SimCond.FldId, strComparisonOpFldId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.KeyFldLst) == true)
{
string strComparisonOpKeyFldLst = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.KeyFldLst];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.KeyFldLst, objvDataNode_SimCond.KeyFldLst, strComparisonOpKeyFldLst);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.DataNodeTypeId) == true)
{
string strComparisonOpDataNodeTypeId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.DataNodeTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.DataNodeTypeId, objvDataNode_SimCond.DataNodeTypeId, strComparisonOpDataNodeTypeId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.VersionNo) == true)
{
string strComparisonOpVersionNo = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.VersionNo];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.VersionNo, objvDataNode_SimCond.VersionNo, strComparisonOpVersionNo);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDataNode_Sim.PrjId, objvDataNode_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.PosX) == true)
{
string strComparisonOpPosX = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.PosX];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.PosX, objvDataNode_SimCond.PosX, strComparisonOpPosX);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.PosY) == true)
{
string strComparisonOpPosY = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.PosY];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.PosY, objvDataNode_SimCond.PosY, strComparisonOpPosY);
}
if (objvDataNode_SimCond.IsUpdated(convDataNode_Sim.UsedTimes) == true)
{
string strComparisonOpUsedTimes = objvDataNode_SimCond.dicFldComparisonOp[convDataNode_Sim.UsedTimes];
strWhereCond += string.Format(" And {0} {2} {1}", convDataNode_Sim.UsedTimes, objvDataNode_SimCond.UsedTimes, strComparisonOpUsedTimes);
}
 return strWhereCond;
}
}
 /// <summary>
 /// vDataNode_Sim(vDataNode_Sim)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvDataNode_SimWApi
{
private static readonly string mstrApiControllerName = "vDataNode_SimApi";

 public clsvDataNode_SimWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_DataNodeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vDataNode_Sim]...","0");
List<clsvDataNode_SimEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="DataNodeId";
objDDL.DataTextField="DataNodeName";
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

 /// <param name = "strCmPrjId"></param>
 /// <param name = "strPrjId"></param>
public static void BindCbo_DataNodeId(System.Windows.Forms.ComboBox objComboBox , string strCmPrjId,string strPrjId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convDataNode_Sim.DataNodeId); 
List<clsvDataNode_SimEN> arrObjLst = clsvDataNode_SimWApi.GetObjLst(strCondition).OrderBy(x=>x.DataNodeName).ToList();
var arrObjLstSel = arrObjLst.Where(x=>x.PrjId == strPrjId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN()
{
DataNodeId = 0,
DataNodeName = "选[vDataNode_Sim]..."
};
arrObjLstSel.Insert(0, objvDataNode_SimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convDataNode_Sim.DataNodeId;
objComboBox.DisplayMember = convDataNode_Sim.DataNodeName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDataNode_SimEN GetObjByDataNodeId(long lngDataNodeId)
{
if (lngDataNodeId == 0) return null;
string strAction = "GetObjByDataNodeId";
clsvDataNode_SimEN objvDataNode_SimEN;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngDataNodeId"] = lngDataNodeId.ToString(),
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObj"]);
objvDataNode_SimEN = JsonConvert.DeserializeObject<clsvDataNode_SimEN>(strJson);
return objvDataNode_SimEN;
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
public static clsvDataNode_SimEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
clsvDataNode_SimEN objvDataNode_SimEN;
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
objvDataNode_SimEN = JsonConvert.DeserializeObject<clsvDataNode_SimEN>(strJson);
return objvDataNode_SimEN;
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
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDataNode_SimEN GetObjByDataNodeIdCache(long lngDataNodeId,string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDataNode_SimEN> arrvDataNode_SimObjLst_Sel =
from objvDataNode_SimEN in arrvDataNode_SimObjLstCache
where objvDataNode_SimEN.DataNodeId == lngDataNodeId 
select objvDataNode_SimEN;
if (arrvDataNode_SimObjLst_Sel.Count() == 0)
{
   clsvDataNode_SimEN obj = clsvDataNode_SimWApi.GetObjByDataNodeId(lngDataNodeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvDataNode_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetDataNodeNameByDataNodeIdCache(long lngDataNodeId,string strPrjId)
{
//初始化列表缓存
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDataNode_SimEN> arrvDataNode_SimObjLst_Sel1 =
from objvDataNode_SimEN in arrvDataNode_SimObjLstCache
where objvDataNode_SimEN.DataNodeId == lngDataNodeId 
select objvDataNode_SimEN;
List <clsvDataNode_SimEN> arrvDataNode_SimObjLst_Sel = new List<clsvDataNode_SimEN>();
foreach (clsvDataNode_SimEN obj in arrvDataNode_SimObjLst_Sel1)
{
arrvDataNode_SimObjLst_Sel.Add(obj);
}
if (arrvDataNode_SimObjLst_Sel.Count > 0)
{
return arrvDataNode_SimObjLst_Sel[0].DataNodeName;
}
string strErrMsgForGetObjById = string.Format("在vDataNode_Sim对象缓存列表中,找不到记录[DataNodeId = {0}](函数:{1})", lngDataNodeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvDataNode_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngDataNodeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByDataNodeIdCache(long lngDataNodeId,string strPrjId)
{
//初始化列表缓存
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDataNode_SimEN> arrvDataNode_SimObjLst_Sel1 =
from objvDataNode_SimEN in arrvDataNode_SimObjLstCache
where objvDataNode_SimEN.DataNodeId == lngDataNodeId 
select objvDataNode_SimEN;
List <clsvDataNode_SimEN> arrvDataNode_SimObjLst_Sel = new List<clsvDataNode_SimEN>();
foreach (clsvDataNode_SimEN obj in arrvDataNode_SimObjLst_Sel1)
{
arrvDataNode_SimObjLst_Sel.Add(obj);
}
if (arrvDataNode_SimObjLst_Sel.Count > 0)
{
return arrvDataNode_SimObjLst_Sel[0].DataNodeName;
}
string strErrMsgForGetObjById = string.Format("在vDataNode_Sim对象缓存列表中,找不到记录的相关名称[DataNodeId = {0}](函数:{1})", lngDataNodeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvDataNode_SimBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNode_SimEN> GetObjLst(string strWhereCond)
{
 List<clsvDataNode_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNode_SimEN>>(strJson);
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
 /// <param name = "arrDataNodeId">关键字列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNode_SimEN> GetObjLstByDataNodeIdLst(List<long> arrDataNodeId)
{
 List<clsvDataNode_SimEN> arrObjLst; 
string strAction = "GetObjLstByDataNodeIdLst";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrDataNodeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)
{
JObject jobjReturn0 = JObject.Parse(strResult);
if ((int)jobjReturn0["errorId"] == 0)
{
string strJson = JsonConvert.SerializeObject(jobjReturn0["returnObjLst"]);
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNode_SimEN>>(strJson);
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
 /// <param name = "arrDataNodeId">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象</returns>
public static IEnumerable<clsvDataNode_SimEN> GetObjLstByDataNodeIdLstCache(List<long> arrDataNodeId, string strPrjId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvDataNode_SimEN> arrvDataNode_SimObjLst_Sel =
from objvDataNode_SimEN in arrvDataNode_SimObjLstCache
where arrDataNodeId.Contains(objvDataNode_SimEN.DataNodeId)
select objvDataNode_SimEN;
return arrvDataNode_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDataNode_SimEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvDataNode_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNode_SimEN>>(strJson);
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
public static List<clsvDataNode_SimEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvDataNode_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNode_SimEN>>(strJson);
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
public static List<clsvDataNode_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvDataNode_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNode_SimEN>>(strJson);
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
public static List<clsvDataNode_SimEN> GetObjLstByPagerCache(stuPagerPara objPagerPara)
{
 List<clsvDataNode_SimEN> arrObjLst; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvDataNode_SimEN>>(strJson);
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
public static bool IsExist(long lngDataNodeId)
{
//检测记录是否存在
string strAction = "IsExist";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["lngDataNodeId"] = lngDataNodeId.ToString()
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
 /// <param name = "objvDataNode_SimENS">源对象</param>
 /// <param name = "objvDataNode_SimENT">目标对象</param>
 public static void CopyTo(clsvDataNode_SimEN objvDataNode_SimENS, clsvDataNode_SimEN objvDataNode_SimENT)
{
try
{
objvDataNode_SimENT.DataNodeId = objvDataNode_SimENS.DataNodeId; //数据结点Id
objvDataNode_SimENT.DataNodeName = objvDataNode_SimENS.DataNodeName; //数据结点名
objvDataNode_SimENT.TabId = objvDataNode_SimENS.TabId; //表ID
objvDataNode_SimENT.FldId = objvDataNode_SimENS.FldId; //字段Id
objvDataNode_SimENT.KeyFldLst = objvDataNode_SimENS.KeyFldLst; //关键字段Id列表
objvDataNode_SimENT.DataNodeTypeId = objvDataNode_SimENS.DataNodeTypeId; //数据结点类型Id
objvDataNode_SimENT.VersionNo = objvDataNode_SimENS.VersionNo; //版本号
objvDataNode_SimENT.PrjId = objvDataNode_SimENS.PrjId; //工程Id
objvDataNode_SimENT.PosX = objvDataNode_SimENS.PosX; //位置X
objvDataNode_SimENT.PosY = objvDataNode_SimENS.PosY; //位置Y
objvDataNode_SimENT.UsedTimes = objvDataNode_SimENS.UsedTimes; //使用次数
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
public static DataTable ToDataTable(List<clsvDataNode_SimEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvDataNode_SimEN._AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvDataNode_SimEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvDataNode_SimEN._AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvDataNode_SimEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvDataNode_SimEN._AttributeName)
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
public static void ReFreshThisCache(string strPrjId = "")
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDataNode_SimWApi.ReFreshThisCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDataNode_SimWApi.ReFreshThisCache)", strPrjId.Length);
throw new Exception (strMsg);
}
string strMsg0;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
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
public static List<clsvDataNode_SimEN> GetObjLstCache(string strPrjId)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDataNode_SimWApi.GetObjLstCache)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDataNode_SimWApi.GetObjLstCache)", strPrjId.Length);
throw new Exception (strMsg);
}
//初始化列表缓存
var strWhereCond = "1=1";
if (string.IsNullOrEmpty(clsvDataNode_SimEN._WhereFormat) == false)
{
strWhereCond =string.Format(clsvDataNode_SimEN._WhereFormat, strPrjId);
}
else
{
strWhereCond = string.Format("{0}='{1}'",convDataNode_Sim.PrjId, strPrjId);
}
var strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strWhereCond); });
return arrvDataNode_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表, 缓存内容来自于另一个对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstCacheFromObjLst)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDataNode_SimEN> GetObjLstCacheFromObjLst(string strPrjId,List<clsvDataNode_SimEN> arrObjLst_P)
{


if (string.IsNullOrEmpty(strPrjId) == true)
{
  var strMsg = string.Format("参数:[strPrjId]不能为空！(In clsvDataNode_SimWApi.GetObjLstCacheFromObjLst)");
 throw new Exception  (strMsg);
}
if (strPrjId.Length != 4)
{
var strMsg = string.Format("缓存分类变量:[strPrjId]的长度:[{0}]不正确！(clsvDataNode_SimWApi.GetObjLstCacheFromObjLst)", strPrjId.Length);
throw new Exception (strMsg);
}
var strKey = string.Format("{0}_{1}", clsvDataNode_SimEN._CurrTabName, strPrjId);
List<clsvDataNode_SimEN> arrvDataNode_SimObjLstCache = null;
if (CacheHelper.Exsits(strKey) == true)
{
arrvDataNode_SimObjLstCache = CacheHelper.Get<List<clsvDataNode_SimEN>>(strKey);
}
else
{
var arrObjLst_Sel = arrObjLst_P.Where(x => x.PrjId == strPrjId).ToList();
CacheHelper.Add(strKey, arrObjLst_Sel);
arrvDataNode_SimObjLstCache = CacheHelper.Get<List<clsvDataNode_SimEN>>(strKey);
}
return arrvDataNode_SimObjLstCache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvDataNode_SimEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convDataNode_Sim.DataNodeId, Type.GetType("System.Int64"));
objDT.Columns.Add(convDataNode_Sim.DataNodeName, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode_Sim.TabId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode_Sim.FldId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode_Sim.KeyFldLst, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode_Sim.DataNodeTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode_Sim.VersionNo, Type.GetType("System.Int32"));
objDT.Columns.Add(convDataNode_Sim.PrjId, Type.GetType("System.String"));
objDT.Columns.Add(convDataNode_Sim.PosX, Type.GetType("System.Decimal"));
objDT.Columns.Add(convDataNode_Sim.PosY, Type.GetType("System.Decimal"));
objDT.Columns.Add(convDataNode_Sim.UsedTimes, Type.GetType("System.Int32"));
foreach (clsvDataNode_SimEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convDataNode_Sim.DataNodeId] = objInFor[convDataNode_Sim.DataNodeId];
objDR[convDataNode_Sim.DataNodeName] = objInFor[convDataNode_Sim.DataNodeName];
objDR[convDataNode_Sim.TabId] = objInFor[convDataNode_Sim.TabId];
objDR[convDataNode_Sim.FldId] = objInFor[convDataNode_Sim.FldId];
objDR[convDataNode_Sim.KeyFldLst] = objInFor[convDataNode_Sim.KeyFldLst];
objDR[convDataNode_Sim.DataNodeTypeId] = objInFor[convDataNode_Sim.DataNodeTypeId];
objDR[convDataNode_Sim.VersionNo] = objInFor[convDataNode_Sim.VersionNo];
objDR[convDataNode_Sim.PrjId] = objInFor[convDataNode_Sim.PrjId];
objDR[convDataNode_Sim.PosX] = objInFor[convDataNode_Sim.PosX];
objDR[convDataNode_Sim.PosY] = objInFor[convDataNode_Sim.PosY];
objDR[convDataNode_Sim.UsedTimes] = objInFor[convDataNode_Sim.UsedTimes];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}