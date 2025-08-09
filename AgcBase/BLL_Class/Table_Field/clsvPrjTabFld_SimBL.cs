
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabFld_SimBL
 表名:vPrjTabFld_Sim(00050589)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
public static class  clsvPrjTabFld_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabFld_SimEN GetObj(this K_mId_vPrjTabFld_Sim myKey)
{
clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = clsvPrjTabFld_SimBL.vPrjTabFld_SimDA.GetObjBymId(myKey.Value);
return objvPrjTabFld_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetmId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, long lngmId, string strComparisonOp="")
	{
objvPrjTabFld_SimEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.mId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.mId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.mId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetTabId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, string strTabId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTabId, convPrjTabFld_Sim.TabId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTabFld_Sim.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTabFld_Sim.TabId);
}
objvPrjTabFld_SimEN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.TabId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.TabId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.TabId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetPrjId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, string strPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrjId, convPrjTabFld_Sim.PrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrjId, 4, convPrjTabFld_Sim.PrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrjId, 4, convPrjTabFld_Sim.PrjId);
}
objvPrjTabFld_SimEN.PrjId = strPrjId; //工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.PrjId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.PrjId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.PrjId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetFldId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convPrjTabFld_Sim.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convPrjTabFld_Sim.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convPrjTabFld_Sim.FldId);
}
objvPrjTabFld_SimEN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.FldId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.FldId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.FldId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetSequenceNumber(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, int? intSequenceNumber, string strComparisonOp="")
	{
objvPrjTabFld_SimEN.SequenceNumber = intSequenceNumber; //顺序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.SequenceNumber) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.SequenceNumber, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.SequenceNumber] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetFieldTypeId(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, string strFieldTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldTypeId, convPrjTabFld_Sim.FieldTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convPrjTabFld_Sim.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convPrjTabFld_Sim.FieldTypeId);
}
objvPrjTabFld_SimEN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.FieldTypeId) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.FieldTypeId, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.FieldTypeId] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabFld_SimEN SetIsForExtendClass(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN, bool bolIsForExtendClass, string strComparisonOp="")
	{
objvPrjTabFld_SimEN.IsForExtendClass = bolIsForExtendClass; //用于扩展类
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabFld_SimEN.dicFldComparisonOp.ContainsKey(convPrjTabFld_Sim.IsForExtendClass) == false)
{
objvPrjTabFld_SimEN.dicFldComparisonOp.Add(convPrjTabFld_Sim.IsForExtendClass, strComparisonOp);
}
else
{
objvPrjTabFld_SimEN.dicFldComparisonOp[convPrjTabFld_Sim.IsForExtendClass] = strComparisonOp;
}
}
return objvPrjTabFld_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimENS">源对象</param>
 /// <param name = "objvPrjTabFld_SimENT">目标对象</param>
 public static void CopyTo(this clsvPrjTabFld_SimEN objvPrjTabFld_SimENS, clsvPrjTabFld_SimEN objvPrjTabFld_SimENT)
{
try
{
objvPrjTabFld_SimENT.mId = objvPrjTabFld_SimENS.mId; //mId
objvPrjTabFld_SimENT.TabId = objvPrjTabFld_SimENS.TabId; //表ID
objvPrjTabFld_SimENT.PrjId = objvPrjTabFld_SimENS.PrjId; //工程Id
objvPrjTabFld_SimENT.FldId = objvPrjTabFld_SimENS.FldId; //字段Id
objvPrjTabFld_SimENT.SequenceNumber = objvPrjTabFld_SimENS.SequenceNumber; //顺序号
objvPrjTabFld_SimENT.FieldTypeId = objvPrjTabFld_SimENS.FieldTypeId; //字段类型Id
objvPrjTabFld_SimENT.IsForExtendClass = objvPrjTabFld_SimENS.IsForExtendClass; //用于扩展类
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
 /// <param name = "objvPrjTabFld_SimENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTabFld_SimEN:objvPrjTabFld_SimENT</returns>
 public static clsvPrjTabFld_SimEN CopyTo(this clsvPrjTabFld_SimEN objvPrjTabFld_SimENS)
{
try
{
 clsvPrjTabFld_SimEN objvPrjTabFld_SimENT = new clsvPrjTabFld_SimEN()
{
mId = objvPrjTabFld_SimENS.mId, //mId
TabId = objvPrjTabFld_SimENS.TabId, //表ID
PrjId = objvPrjTabFld_SimENS.PrjId, //工程Id
FldId = objvPrjTabFld_SimENS.FldId, //字段Id
SequenceNumber = objvPrjTabFld_SimENS.SequenceNumber, //顺序号
FieldTypeId = objvPrjTabFld_SimENS.FieldTypeId, //字段类型Id
IsForExtendClass = objvPrjTabFld_SimENS.IsForExtendClass, //用于扩展类
};
 return objvPrjTabFld_SimENT;
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
public static void CheckProperty4Condition(this clsvPrjTabFld_SimEN objvPrjTabFld_SimEN)
{
 clsvPrjTabFld_SimBL.vPrjTabFld_SimDA.CheckProperty4Condition(objvPrjTabFld_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTabFld_SimEN objvPrjTabFld_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.mId) == true)
{
string strComparisonOpmId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld_Sim.mId, objvPrjTabFld_SimCond.mId, strComparisonOpmId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.TabId) == true)
{
string strComparisonOpTabId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld_Sim.TabId, objvPrjTabFld_SimCond.TabId, strComparisonOpTabId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.PrjId) == true)
{
string strComparisonOpPrjId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.PrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld_Sim.PrjId, objvPrjTabFld_SimCond.PrjId, strComparisonOpPrjId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.FldId) == true)
{
string strComparisonOpFldId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld_Sim.FldId, objvPrjTabFld_SimCond.FldId, strComparisonOpFldId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.SequenceNumber) == true)
{
string strComparisonOpSequenceNumber = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.SequenceNumber];
strWhereCond += string.Format(" And {0} {2} {1}", convPrjTabFld_Sim.SequenceNumber, objvPrjTabFld_SimCond.SequenceNumber, strComparisonOpSequenceNumber);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvPrjTabFld_SimCond.dicFldComparisonOp[convPrjTabFld_Sim.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabFld_Sim.FieldTypeId, objvPrjTabFld_SimCond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvPrjTabFld_SimCond.IsUpdated(convPrjTabFld_Sim.IsForExtendClass) == true)
{
if (objvPrjTabFld_SimCond.IsForExtendClass == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjTabFld_Sim.IsForExtendClass);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjTabFld_Sim.IsForExtendClass);
}
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTabFld_Sim
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v工程表字段_Sim(vPrjTabFld_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabFld_SimBL
{
public static RelatedActions_vPrjTabFld_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTabFld_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTabFld_SimDA vPrjTabFld_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTabFld_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTabFld_SimBL()
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
if (string.IsNullOrEmpty(clsvPrjTabFld_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTabFld_SimEN._ConnectString);
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
public static DataTable GetDataTable_vPrjTabFld_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTabFld_SimDA.GetDataTable_vPrjTabFld_Sim(strWhereCond);
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
objDT = vPrjTabFld_SimDA.GetDataTable(strWhereCond);
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
objDT = vPrjTabFld_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjTabFld_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjTabFld_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjTabFld_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjTabFld_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjTabFld_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjTabFld_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvPrjTabFld_SimEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
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
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTabFld_SimEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
List<clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLst_Sel =
arrvPrjTabFld_SimObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvPrjTabFld_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetObjLst(string strWhereCond)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
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
public static List<clsvPrjTabFld_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjTabFld_SimEN> GetSubObjLstCache(clsvPrjTabFld_SimEN objvPrjTabFld_SimCond)
{
 string strPrjId = objvPrjTabFld_SimCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjTabFld_SimBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabFld_SimEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFld_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTabFld_Sim._AttributeName)
{
if (objvPrjTabFld_SimCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabFld_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabFld_SimCond[strFldName].ToString());
}
else
{
if (objvPrjTabFld_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabFld_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabFld_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabFld_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabFld_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabFld_SimCond[strFldName]));
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
public static List<clsvPrjTabFld_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
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
public static List<clsvPrjTabFld_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
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
List<clsvPrjTabFld_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjTabFld_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjTabFld_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
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
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
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
public static List<clsvPrjTabFld_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjTabFld_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
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
public static List<clsvPrjTabFld_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTabFld_SimEN> arrObjLst = new List<clsvPrjTabFld_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = new clsvPrjTabFld_SimEN();
try
{
objvPrjTabFld_SimEN.mId = Int32.Parse(objRow[convPrjTabFld_Sim.mId].ToString().Trim()); //mId
objvPrjTabFld_SimEN.TabId = objRow[convPrjTabFld_Sim.TabId].ToString().Trim(); //表ID
objvPrjTabFld_SimEN.PrjId = objRow[convPrjTabFld_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTabFld_SimEN.FldId = objRow[convPrjTabFld_Sim.FldId].ToString().Trim(); //字段Id
objvPrjTabFld_SimEN.SequenceNumber = objRow[convPrjTabFld_Sim.SequenceNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTabFld_Sim.SequenceNumber].ToString().Trim()); //顺序号
objvPrjTabFld_SimEN.FieldTypeId = objRow[convPrjTabFld_Sim.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabFld_SimEN.IsForExtendClass = clsEntityBase2.TransNullToBool_S(objRow[convPrjTabFld_Sim.IsForExtendClass].ToString().Trim()); //用于扩展类
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabFld_SimEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabFld_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTabFld_Sim(ref clsvPrjTabFld_SimEN objvPrjTabFld_SimEN)
{
bool bolResult = vPrjTabFld_SimDA.GetvPrjTabFld_Sim(ref objvPrjTabFld_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabFld_SimEN GetObjBymId(long lngmId)
{
clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = vPrjTabFld_SimDA.GetObjBymId(lngmId);
return objvPrjTabFld_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTabFld_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = vPrjTabFld_SimDA.GetFirstObj(strWhereCond);
 return objvPrjTabFld_SimEN;
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
public static clsvPrjTabFld_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = vPrjTabFld_SimDA.GetObjByDataRow(objRow);
 return objvPrjTabFld_SimEN;
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
public static clsvPrjTabFld_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTabFld_SimEN objvPrjTabFld_SimEN = vPrjTabFld_SimDA.GetObjByDataRow(objRow);
 return objvPrjTabFld_SimEN;
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
 /// <param name = "lstvPrjTabFld_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabFld_SimEN GetObjBymIdFromList(long lngmId, List<clsvPrjTabFld_SimEN> lstvPrjTabFld_SimObjLst)
{
foreach (clsvPrjTabFld_SimEN objvPrjTabFld_SimEN in lstvPrjTabFld_SimObjLst)
{
if (objvPrjTabFld_SimEN.mId == lngmId)
{
return objvPrjTabFld_SimEN;
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
 lngmId = new clsvPrjTabFld_SimDA().GetFirstID(strWhereCond);
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
 arrList = vPrjTabFld_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjTabFld_SimDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vPrjTabFld_SimDA.IsExist(lngmId);
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
 bolIsExist = clsvPrjTabFld_SimDA.IsExistTable();
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
 bolIsExist = vPrjTabFld_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjTabFld_SimENS">源对象</param>
 /// <param name = "objvPrjTabFld_SimENT">目标对象</param>
 public static void CopyTo(clsvPrjTabFld_SimEN objvPrjTabFld_SimENS, clsvPrjTabFld_SimEN objvPrjTabFld_SimENT)
{
try
{
objvPrjTabFld_SimENT.mId = objvPrjTabFld_SimENS.mId; //mId
objvPrjTabFld_SimENT.TabId = objvPrjTabFld_SimENS.TabId; //表ID
objvPrjTabFld_SimENT.PrjId = objvPrjTabFld_SimENS.PrjId; //工程Id
objvPrjTabFld_SimENT.FldId = objvPrjTabFld_SimENS.FldId; //字段Id
objvPrjTabFld_SimENT.SequenceNumber = objvPrjTabFld_SimENS.SequenceNumber; //顺序号
objvPrjTabFld_SimENT.FieldTypeId = objvPrjTabFld_SimENS.FieldTypeId; //字段类型Id
objvPrjTabFld_SimENT.IsForExtendClass = objvPrjTabFld_SimENS.IsForExtendClass; //用于扩展类
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
 /// <param name = "objvPrjTabFld_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTabFld_SimEN objvPrjTabFld_SimEN)
{
try
{
objvPrjTabFld_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTabFld_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTabFld_Sim.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFld_SimEN.mId = objvPrjTabFld_SimEN.mId; //mId
}
if (arrFldSet.Contains(convPrjTabFld_Sim.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFld_SimEN.TabId = objvPrjTabFld_SimEN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTabFld_Sim.PrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFld_SimEN.PrjId = objvPrjTabFld_SimEN.PrjId; //工程Id
}
if (arrFldSet.Contains(convPrjTabFld_Sim.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFld_SimEN.FldId = objvPrjTabFld_SimEN.FldId; //字段Id
}
if (arrFldSet.Contains(convPrjTabFld_Sim.SequenceNumber, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFld_SimEN.SequenceNumber = objvPrjTabFld_SimEN.SequenceNumber; //顺序号
}
if (arrFldSet.Contains(convPrjTabFld_Sim.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFld_SimEN.FieldTypeId = objvPrjTabFld_SimEN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convPrjTabFld_Sim.IsForExtendClass, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabFld_SimEN.IsForExtendClass = objvPrjTabFld_SimEN.IsForExtendClass; //用于扩展类
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
 /// <param name = "objvPrjTabFld_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTabFld_SimEN objvPrjTabFld_SimEN)
{
try
{
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
public static void CheckProperty4Condition(clsvPrjTabFld_SimEN objvPrjTabFld_SimEN)
{
 vPrjTabFld_SimDA.CheckProperty4Condition(objvPrjTabFld_SimEN);
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
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvPrjTabFld_SimObjLstCache == null)
//{
//arrvPrjTabFld_SimObjLstCache = vPrjTabFld_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabFld_SimEN GetObjBymIdCache(long lngmId, string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
List<clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLst_Sel =
arrvPrjTabFld_SimObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvPrjTabFld_SimObjLst_Sel.Count() == 0)
{
   clsvPrjTabFld_SimEN obj = clsvPrjTabFld_SimBL.GetObjBymId(lngmId);
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
return arrvPrjTabFld_SimObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetAllvPrjTabFld_SimObjLstCache(string strPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLstCache = GetObjLstCache(strPrjId); 
return arrvPrjTabFld_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabFld_SimEN> GetObjLstCache(string strPrjId)
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
string strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
string strCondition = string.Format("PrjId='{0}'", strPrjId);
List<clsvPrjTabFld_SimEN> arrvPrjTabFld_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTabFld_SimObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvPrjTabFld_SimEN._CurrTabName, strPrjId);
CacheHelper.Remove(strKey);
clsvPrjTabFld_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjTabFld_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTabFld_SimEN._RefreshTimeLst[clsvPrjTabFld_SimEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strPrjId)
{
if (strInFldName != convPrjTabFld_Sim.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTabFld_Sim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTabFld_Sim._AttributeName));
throw new Exception(strMsg);
}
var objvPrjTabFld_Sim = clsvPrjTabFld_SimBL.GetObjBymIdCache(lngmId, strPrjId);
if (objvPrjTabFld_Sim == null) return "";
return objvPrjTabFld_Sim[strOutFldName].ToString();
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
int intRecCount = clsvPrjTabFld_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjTabFld_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTabFld_SimDA.GetRecCount();
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
int intRecCount = clsvPrjTabFld_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjTabFld_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjTabFld_SimEN objvPrjTabFld_SimCond)
{
 string strPrjId = objvPrjTabFld_SimCond.PrjId;
 if (string.IsNullOrEmpty(strPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjTabFld_SimBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabFld_SimEN> arrObjLstCache = GetObjLstCache(strPrjId);
IEnumerable <clsvPrjTabFld_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTabFld_Sim._AttributeName)
{
if (objvPrjTabFld_SimCond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabFld_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabFld_SimCond[strFldName].ToString());
}
else
{
if (objvPrjTabFld_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabFld_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabFld_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabFld_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabFld_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabFld_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabFld_SimCond[strFldName]));
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
 List<string> arrList = clsvPrjTabFld_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjTabFld_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjTabFld_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}