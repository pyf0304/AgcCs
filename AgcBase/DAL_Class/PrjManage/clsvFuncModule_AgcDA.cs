
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModule_AgcDA
 表名:vFuncModule_Agc(00050125)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
 框架-层名:数据处理层(CS)(DALCode,0002)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using PrjCommBase;
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// v功能模块_Agc(vFuncModule_Agc)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFuncModule_AgcDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsvFuncModule_AgcEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
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
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvFuncModule_AgcEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncModule_AgcEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsvFuncModule_AgcEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFuncModule_AgcEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncModuleAgcId)
{
strFuncModuleAgcId = strFuncModuleAgcId.Replace("'", "''");
if (strFuncModuleAgcId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vFuncModule_Agc中,检查关键字,长度不正确!(clsvFuncModule_AgcDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncModuleAgcId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFuncModule_Agc中,关键字不能为空 或 null!(clsvFuncModule_AgcDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncModuleAgcId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFuncModule_AgcDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from vFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFuncModule_Agc(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTable_vFuncModule_Agc)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from vFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from vFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncModule_Agc where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncModule_Agc where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFuncModule_Agc where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);
if (sortInfo.SortDirection == "" || sortInfo.SortField == "")
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);
strSQL = $"Select Top {intPageSize} vFuncModule_Agc.* " + 
$"from vFuncModule_Agc " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFuncModule_Agc.FuncModuleAgcId not in " + 
$"(Select top {intTop_In} vFuncModule_Agc.FuncModuleAgcId from vFuncModule_Agc " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {2} FuncModuleAgcId from vFuncModule_Agc where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {3} FuncModuleAgcId from vFuncModule_Agc where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);
if (sortInfo.SortDirection == "" || sortInfo.SortField == "")
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);
strSQL = $"Select Top {intPageSize} vFuncModule_Agc.* " + 
$"from vFuncModule_Agc " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFuncModule_Agc.FuncModuleAgcId not in " + 
$"(Select top {intTop_In} vFuncModule_Agc.FuncModuleAgcId from vFuncModule_Agc " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {2} FuncModuleAgcId from vFuncModule_Agc where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncModule_Agc where {1} and FuncModuleAgcId not in (Select top {3} FuncModuleAgcId from vFuncModule_Agc where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsvFuncModule_AgcEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA:GetObjLst)", objException.Message));
}
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from vFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFuncModule_AgcDA: GetObjLst)", objException.Message));
}
objvFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFuncModule_AgcEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsvFuncModule_AgcEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFuncModule_AgcEN> arrObjLst = new List<clsvFuncModule_AgcEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFuncModule_AgcDA: GetObjLst)", objException.Message));
}
objvFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFuncModule_AgcEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFuncModule_AgcEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFuncModule_Agc(ref clsvFuncModule_AgcEN objvFuncModule_AgcEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from vFuncModule_Agc where FuncModuleAgcId = " + "'"+ objvFuncModule_AgcEN.FuncModuleAgcId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFuncModule_AgcEN.FuncModuleAgcId = objDT.Rows[0][convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvFuncModule_AgcEN.TabNum = TransNullToInt(objDT.Rows[0][convFuncModule_Agc.TabNum].ToString().Trim()); //表数(字段类型:int,字段长度:4,是否可空:True)
 objvFuncModule_AgcEN.ViewNum = TransNullToInt(objDT.Rows[0][convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数(字段类型:int,字段长度:4,是否可空:True)
 objvFuncModule_AgcEN.ObjNum = TransNullToInt(objDT.Rows[0][convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum(字段类型:int,字段长度:4,是否可空:True)
 objvFuncModule_AgcEN.PrjViewNum = TransNullToInt(objDT.Rows[0][convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum(字段类型:int,字段长度:4,是否可空:True)
 objvFuncModule_AgcEN.FuncModuleName = objDT.Rows[0][convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFuncModule_AgcEN.FuncModuleEnName = objDT.Rows[0][convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvFuncModule_AgcEN.PrjId = objDT.Rows[0][convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFuncModule_AgcEN.PrjName = objDT.Rows[0][convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFuncModule_AgcEN.OrderNum = TransNullToInt(objDT.Rows[0][convFuncModule_Agc.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFuncModule_AgcEN.UseStateId = objDT.Rows[0][convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objvFuncModule_AgcEN.UseStateName = objDT.Rows[0][convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFuncModule_AgcEN.UpdDate = objDT.Rows[0][convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncModule_AgcEN.Memo = objDT.Rows[0][convFuncModule_Agc.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncModule_AgcEN.UpdUser = objDT.Rows[0][convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFuncModule_AgcDA: GetvFuncModule_Agc)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFuncModule_AgcEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
CheckPrimaryKey(strFuncModuleAgcId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from vFuncModule_Agc where FuncModuleAgcId = " + "'"+ strFuncModuleAgcId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
 objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数(字段类型:int,字段长度:4,是否可空:True)
 objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数(字段类型:int,字段长度:4,是否可空:True)
 objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum(字段类型:int,字段长度:4,是否可空:True)
 objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum(字段类型:int,字段长度:4,是否可空:True)
 objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFuncModule_AgcEN.OrderNum = Int32.Parse(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFuncModule_AgcDA: GetObjByFuncModuleAgcId)", objException.Message));
}
return objvFuncModule_AgcEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFuncModule_AgcEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
strSQL = "Select * from vFuncModule_Agc where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN()
{
FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(), //功能模块Id
TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.TabNum].ToString().Trim()), //表数
ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()), //界面数
ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()), //ObjNum
PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()), //PrjViewNum
FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(), //工程名称
OrderNum = TransNullToInt(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()), //序号
UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(), //使用状态Id
UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(), //使用状态名称
UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(), //说明
UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim() //修改者
};
objvFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncModule_AgcEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFuncModule_AgcDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFuncModule_AgcEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFuncModule_AgcDA: GetObjByDataRowvFuncModule_Agc)", objException.Message));
}
objvFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncModule_AgcEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFuncModule_AgcEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFuncModule_AgcEN objvFuncModule_AgcEN = new clsvFuncModule_AgcEN();
try
{
objvFuncModule_AgcEN.FuncModuleAgcId = objRow[convFuncModule_Agc.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModule_AgcEN.TabNum = objRow[convFuncModule_Agc.TabNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.TabNum].ToString().Trim()); //表数
objvFuncModule_AgcEN.ViewNum = objRow[convFuncModule_Agc.ViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ViewNum].ToString().Trim()); //界面数
objvFuncModule_AgcEN.ObjNum = objRow[convFuncModule_Agc.ObjNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.ObjNum].ToString().Trim()); //ObjNum
objvFuncModule_AgcEN.PrjViewNum = objRow[convFuncModule_Agc.PrjViewNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFuncModule_Agc.PrjViewNum].ToString().Trim()); //PrjViewNum
objvFuncModule_AgcEN.FuncModuleName = objRow[convFuncModule_Agc.FuncModuleName].ToString().Trim(); //功能模块名称
objvFuncModule_AgcEN.FuncModuleEnName = objRow[convFuncModule_Agc.FuncModuleEnName] == DBNull.Value ? null : objRow[convFuncModule_Agc.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvFuncModule_AgcEN.PrjId = objRow[convFuncModule_Agc.PrjId].ToString().Trim(); //工程Id
objvFuncModule_AgcEN.PrjName = objRow[convFuncModule_Agc.PrjName].ToString().Trim(); //工程名称
objvFuncModule_AgcEN.OrderNum = TransNullToInt(objRow[convFuncModule_Agc.OrderNum].ToString().Trim()); //序号
objvFuncModule_AgcEN.UseStateId = objRow[convFuncModule_Agc.UseStateId].ToString().Trim(); //使用状态Id
objvFuncModule_AgcEN.UseStateName = objRow[convFuncModule_Agc.UseStateName] == DBNull.Value ? null : objRow[convFuncModule_Agc.UseStateName].ToString().Trim(); //使用状态名称
objvFuncModule_AgcEN.UpdDate = objRow[convFuncModule_Agc.UpdDate] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdDate].ToString().Trim(); //修改日期
objvFuncModule_AgcEN.Memo = objRow[convFuncModule_Agc.Memo] == DBNull.Value ? null : objRow[convFuncModule_Agc.Memo].ToString().Trim(); //说明
objvFuncModule_AgcEN.UpdUser = objRow[convFuncModule_Agc.UpdUser] == DBNull.Value ? null : objRow[convFuncModule_Agc.UpdUser].ToString().Trim(); //修改者
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFuncModule_AgcDA: GetObjByDataRow)", objException.Message));
}
objvFuncModule_AgcEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncModule_AgcEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFuncModule_AgcEN._CurrTabName, convFuncModule_Agc.FuncModuleAgcId, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFuncModule_AgcEN._CurrTabName, convFuncModule_Agc.FuncModuleAgcId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncModuleAgcId from vFuncModule_Agc where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncModuleAgcId from vFuncModule_Agc where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExist_S)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncModuleAgcId)
{
CheckPrimaryKey(strFuncModuleAgcId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFuncModule_Agc", "FuncModuleAgcId = " + "'"+ strFuncModuleAgcId+"'"))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFuncModule_AgcDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFuncModule_Agc", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFuncModule_Agc");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFuncModule_AgcENS">源对象</param>
 /// <param name = "objvFuncModule_AgcENT">目标对象</param>
public void CopyTo(clsvFuncModule_AgcEN objvFuncModule_AgcENS, clsvFuncModule_AgcEN objvFuncModule_AgcENT)
{
objvFuncModule_AgcENT.FuncModuleAgcId = objvFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
objvFuncModule_AgcENT.TabNum = objvFuncModule_AgcENS.TabNum; //表数
objvFuncModule_AgcENT.ViewNum = objvFuncModule_AgcENS.ViewNum; //界面数
objvFuncModule_AgcENT.ObjNum = objvFuncModule_AgcENS.ObjNum; //ObjNum
objvFuncModule_AgcENT.PrjViewNum = objvFuncModule_AgcENS.PrjViewNum; //PrjViewNum
objvFuncModule_AgcENT.FuncModuleName = objvFuncModule_AgcENS.FuncModuleName; //功能模块名称
objvFuncModule_AgcENT.FuncModuleEnName = objvFuncModule_AgcENS.FuncModuleEnName; //功能模块英文名称
objvFuncModule_AgcENT.PrjId = objvFuncModule_AgcENS.PrjId; //工程Id
objvFuncModule_AgcENT.PrjName = objvFuncModule_AgcENS.PrjName; //工程名称
objvFuncModule_AgcENT.OrderNum = objvFuncModule_AgcENS.OrderNum; //序号
objvFuncModule_AgcENT.UseStateId = objvFuncModule_AgcENS.UseStateId; //使用状态Id
objvFuncModule_AgcENT.UseStateName = objvFuncModule_AgcENS.UseStateName; //使用状态名称
objvFuncModule_AgcENT.UpdDate = objvFuncModule_AgcENS.UpdDate; //修改日期
objvFuncModule_AgcENT.Memo = objvFuncModule_AgcENS.Memo; //说明
objvFuncModule_AgcENT.UpdUser = objvFuncModule_AgcENS.UpdUser; //修改者
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFuncModule_AgcEN objvFuncModule_AgcEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.FuncModuleAgcId, 8, convFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.FuncModuleName, 30, convFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.FuncModuleEnName, 30, convFuncModule_Agc.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.PrjId, 4, convFuncModule_Agc.PrjId);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.PrjName, 30, convFuncModule_Agc.PrjName);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.UseStateId, 4, convFuncModule_Agc.UseStateId);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.UseStateName, 30, convFuncModule_Agc.UseStateName);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.UpdDate, 20, convFuncModule_Agc.UpdDate);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.Memo, 1000, convFuncModule_Agc.Memo);
clsCheckSql.CheckFieldLen(objvFuncModule_AgcEN.UpdUser, 20, convFuncModule_Agc.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.FuncModuleAgcId, convFuncModule_Agc.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.FuncModuleName, convFuncModule_Agc.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.FuncModuleEnName, convFuncModule_Agc.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.PrjId, convFuncModule_Agc.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.PrjName, convFuncModule_Agc.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.UseStateId, convFuncModule_Agc.UseStateId);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.UseStateName, convFuncModule_Agc.UseStateName);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.UpdDate, convFuncModule_Agc.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.Memo, convFuncModule_Agc.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFuncModule_AgcEN.UpdUser, convFuncModule_Agc.UpdUser);
//检查外键字段长度
 objvFuncModule_AgcEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFuncModule_AgcEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFuncModule_AgcEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncModule_AgcDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}