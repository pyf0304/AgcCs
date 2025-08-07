
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTabCheckResultDA
 表名:vTabCheckResult(00050191)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:01
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// v表检查结果(vTabCheckResult)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTabCheckResultDA : clsCommBase4DA
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
 return clsvTabCheckResultEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTabCheckResultEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTabCheckResultEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTabCheckResultEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTabCheckResultEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
strSQL = "Select * from vTabCheckResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTabCheckResult(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTable_vTabCheckResult)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
strSQL = "Select * from vTabCheckResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
strSQL = "Select * from vTabCheckResult where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabCheckResult where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabCheckResult where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTabCheckResult where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabCheckResult.* " + 
$"from vTabCheckResult " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabCheckResult.mId not in " + 
$"(Select top {intTop_In} vTabCheckResult.mId from vTabCheckResult " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabCheckResult where {1} and mId not in (Select top {2} mId from vTabCheckResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabCheckResult where {1} and mId not in (Select top {3} mId from vTabCheckResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vTabCheckResult.* " + 
$"from vTabCheckResult " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vTabCheckResult.mId not in " + 
$"(Select top {intTop_In} vTabCheckResult.mId from vTabCheckResult " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTabCheckResult where {1} and mId not in (Select top {2} mId from vTabCheckResult where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTabCheckResult where {1} and mId not in (Select top {3} mId from vTabCheckResult where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTabCheckResultEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTabCheckResultDA:GetObjLst)", objException.Message));
}
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
strSQL = "Select * from vTabCheckResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = TransNullToInt(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = TransNullToInt(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabCheckResultDA: GetObjLst)", objException.Message));
}
objvTabCheckResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabCheckResultEN);
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
public List<clsvTabCheckResultEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTabCheckResultDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTabCheckResultEN> arrObjLst = new List<clsvTabCheckResultEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = TransNullToInt(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = TransNullToInt(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTabCheckResultDA: GetObjLst)", objException.Message));
}
objvTabCheckResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTabCheckResultEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTabCheckResultEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTabCheckResult(ref clsvTabCheckResultEN objvTabCheckResultEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
strSQL = "Select * from vTabCheckResult where mId = " + ""+ objvTabCheckResultEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTabCheckResultEN.mId = TransNullToInt(objDT.Rows[0][convTabCheckResult.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvTabCheckResultEN.PrjId = objDT.Rows[0][convTabCheckResult.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabCheckResultEN.FldId = objDT.Rows[0][convTabCheckResult.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabCheckResultEN.PrjName = objDT.Rows[0][convTabCheckResult.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabCheckResultEN.PrjDataBaseName = objDT.Rows[0][convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabCheckResultEN.PrjDataBaseId = objDT.Rows[0][convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabCheckResultEN.TabId = objDT.Rows[0][convTabCheckResult.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabCheckResultEN.TabName = objDT.Rows[0][convTabCheckResult.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabCheckResultEN.TabCnName = objDT.Rows[0][convTabCheckResult.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabCheckResultEN.FldName = objDT.Rows[0][convTabCheckResult.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabCheckResultEN.ErrorLevelId = TransNullToInt(objDT.Rows[0][convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id(字段类型:int,字段长度:4,是否可空:False)
 objvTabCheckResultEN.ErrorLevelName = objDT.Rows[0][convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabCheckResultEN.ErrorMsg = objDT.Rows[0][convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:5000,是否可空:False)
 objvTabCheckResultEN.CheckDate = objDT.Rows[0][convTabCheckResult.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabCheckResultEN.CheckUser = objDT.Rows[0][convTabCheckResult.CheckUser].ToString().Trim(); //检查人(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabCheckResultEN.Memo = objDT.Rows[0][convTabCheckResult.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTabCheckResultEN.SqlDsTypeId = objDT.Rows[0][convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabCheckResultEN.SqlDsTypeName = objDT.Rows[0][convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabCheckResultEN.DataBaseName = objDT.Rows[0][convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabCheckResultEN.FuncModuleAgcId = objDT.Rows[0][convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabCheckResultEN.FuncModuleName = objDT.Rows[0][convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabCheckResultEN.TabCheckErrorTypeId = objDT.Rows[0][convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabCheckResultEN.TabCheckErrorTypeName = objDT.Rows[0][convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabCheckResultEN.TabStateId = objDT.Rows[0][convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvTabCheckResultEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTabCheckResultDA: GetvTabCheckResult)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTabCheckResultEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
strSQL = "Select * from vTabCheckResult where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
 objvTabCheckResultEN.mId = Int32.Parse(objRow[convTabCheckResult.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名(字段类型:varchar,字段长度:50,是否可空:True)
 objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabCheckResultEN.ErrorLevelId = Int32.Parse(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id(字段类型:int,字段长度:4,是否可空:False)
 objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:5000,是否可空:False)
 objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTabCheckResultDA: GetObjBymId)", objException.Message));
}
return objvTabCheckResultEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTabCheckResultEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTabCheckResultDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
strSQL = "Select * from vTabCheckResult where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN()
{
mId = TransNullToInt(objRow[convTabCheckResult.mId].ToString().Trim()), //mId
PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(), //工程Id
FldId = objRow[convTabCheckResult.FldId].ToString().Trim(), //字段Id
PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(), //工程名称
PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(), //项目数据库名
PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(), //项目数据库Id
TabId = objRow[convTabCheckResult.TabId].ToString().Trim(), //表ID
TabName = objRow[convTabCheckResult.TabName].ToString().Trim(), //表名
TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(), //表中文名
FldName = objRow[convTabCheckResult.FldName].ToString().Trim(), //字段名
ErrorLevelId = TransNullToInt(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()), //错误等级Id
ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(), //错误等级名
ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(), //错误信息
CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(), //检查日期
CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(), //检查人
Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(), //说明
SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(), //数据源类型Id
SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(), //Sql数据源名
DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(), //数据库名
FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(), //功能模块名称
TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(), //表检查错误类型Id
TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(), //表检查错误类型名
TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(), //表状态ID
OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()) //引用序号
};
objvTabCheckResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabCheckResultEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTabCheckResultDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTabCheckResultEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = TransNullToInt(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = TransNullToInt(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTabCheckResultDA: GetObjByDataRowvTabCheckResult)", objException.Message));
}
objvTabCheckResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabCheckResultEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTabCheckResultEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTabCheckResultEN objvTabCheckResultEN = new clsvTabCheckResultEN();
try
{
objvTabCheckResultEN.mId = TransNullToInt(objRow[convTabCheckResult.mId].ToString().Trim()); //mId
objvTabCheckResultEN.PrjId = objRow[convTabCheckResult.PrjId].ToString().Trim(); //工程Id
objvTabCheckResultEN.FldId = objRow[convTabCheckResult.FldId].ToString().Trim(); //字段Id
objvTabCheckResultEN.PrjName = objRow[convTabCheckResult.PrjName].ToString().Trim(); //工程名称
objvTabCheckResultEN.PrjDataBaseName = objRow[convTabCheckResult.PrjDataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.PrjDataBaseName].ToString().Trim(); //项目数据库名
objvTabCheckResultEN.PrjDataBaseId = objRow[convTabCheckResult.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objvTabCheckResultEN.TabId = objRow[convTabCheckResult.TabId].ToString().Trim(); //表ID
objvTabCheckResultEN.TabName = objRow[convTabCheckResult.TabName].ToString().Trim(); //表名
objvTabCheckResultEN.TabCnName = objRow[convTabCheckResult.TabCnName] == DBNull.Value ? null : objRow[convTabCheckResult.TabCnName].ToString().Trim(); //表中文名
objvTabCheckResultEN.FldName = objRow[convTabCheckResult.FldName].ToString().Trim(); //字段名
objvTabCheckResultEN.ErrorLevelId = TransNullToInt(objRow[convTabCheckResult.ErrorLevelId].ToString().Trim()); //错误等级Id
objvTabCheckResultEN.ErrorLevelName = objRow[convTabCheckResult.ErrorLevelName].ToString().Trim(); //错误等级名
objvTabCheckResultEN.ErrorMsg = objRow[convTabCheckResult.ErrorMsg].ToString().Trim(); //错误信息
objvTabCheckResultEN.CheckDate = objRow[convTabCheckResult.CheckDate].ToString().Trim(); //检查日期
objvTabCheckResultEN.CheckUser = objRow[convTabCheckResult.CheckUser].ToString().Trim(); //检查人
objvTabCheckResultEN.Memo = objRow[convTabCheckResult.Memo] == DBNull.Value ? null : objRow[convTabCheckResult.Memo].ToString().Trim(); //说明
objvTabCheckResultEN.SqlDsTypeId = objRow[convTabCheckResult.SqlDsTypeId] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvTabCheckResultEN.SqlDsTypeName = objRow[convTabCheckResult.SqlDsTypeName] == DBNull.Value ? null : objRow[convTabCheckResult.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvTabCheckResultEN.DataBaseName = objRow[convTabCheckResult.DataBaseName] == DBNull.Value ? null : objRow[convTabCheckResult.DataBaseName].ToString().Trim(); //数据库名
objvTabCheckResultEN.FuncModuleAgcId = objRow[convTabCheckResult.FuncModuleAgcId] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvTabCheckResultEN.FuncModuleName = objRow[convTabCheckResult.FuncModuleName] == DBNull.Value ? null : objRow[convTabCheckResult.FuncModuleName].ToString().Trim(); //功能模块名称
objvTabCheckResultEN.TabCheckErrorTypeId = objRow[convTabCheckResult.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objvTabCheckResultEN.TabCheckErrorTypeName = objRow[convTabCheckResult.TabCheckErrorTypeName].ToString().Trim(); //表检查错误类型名
objvTabCheckResultEN.TabStateId = objRow[convTabCheckResult.TabStateId] == DBNull.Value ? null : objRow[convTabCheckResult.TabStateId].ToString().Trim(); //表状态ID
objvTabCheckResultEN.OrderNum4Refer = objRow[convTabCheckResult.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTabCheckResult.OrderNum4Refer].ToString().Trim()); //引用序号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTabCheckResultDA: GetObjByDataRow)", objException.Message));
}
objvTabCheckResultEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTabCheckResultEN;
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
objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabCheckResultEN._CurrTabName, convTabCheckResult.mId, 8, "");
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
objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTabCheckResultEN._CurrTabName, convTabCheckResult.mId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vTabCheckResult where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vTabCheckResult where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabCheckResult", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTabCheckResultDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTabCheckResult", strCondition))
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
objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTabCheckResult");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTabCheckResultENS">源对象</param>
 /// <param name = "objvTabCheckResultENT">目标对象</param>
public void CopyTo(clsvTabCheckResultEN objvTabCheckResultENS, clsvTabCheckResultEN objvTabCheckResultENT)
{
objvTabCheckResultENT.mId = objvTabCheckResultENS.mId; //mId
objvTabCheckResultENT.PrjId = objvTabCheckResultENS.PrjId; //工程Id
objvTabCheckResultENT.FldId = objvTabCheckResultENS.FldId; //字段Id
objvTabCheckResultENT.PrjName = objvTabCheckResultENS.PrjName; //工程名称
objvTabCheckResultENT.PrjDataBaseName = objvTabCheckResultENS.PrjDataBaseName; //项目数据库名
objvTabCheckResultENT.PrjDataBaseId = objvTabCheckResultENS.PrjDataBaseId; //项目数据库Id
objvTabCheckResultENT.TabId = objvTabCheckResultENS.TabId; //表ID
objvTabCheckResultENT.TabName = objvTabCheckResultENS.TabName; //表名
objvTabCheckResultENT.TabCnName = objvTabCheckResultENS.TabCnName; //表中文名
objvTabCheckResultENT.FldName = objvTabCheckResultENS.FldName; //字段名
objvTabCheckResultENT.ErrorLevelId = objvTabCheckResultENS.ErrorLevelId; //错误等级Id
objvTabCheckResultENT.ErrorLevelName = objvTabCheckResultENS.ErrorLevelName; //错误等级名
objvTabCheckResultENT.ErrorMsg = objvTabCheckResultENS.ErrorMsg; //错误信息
objvTabCheckResultENT.CheckDate = objvTabCheckResultENS.CheckDate; //检查日期
objvTabCheckResultENT.CheckUser = objvTabCheckResultENS.CheckUser; //检查人
objvTabCheckResultENT.Memo = objvTabCheckResultENS.Memo; //说明
objvTabCheckResultENT.SqlDsTypeId = objvTabCheckResultENS.SqlDsTypeId; //数据源类型Id
objvTabCheckResultENT.SqlDsTypeName = objvTabCheckResultENS.SqlDsTypeName; //Sql数据源名
objvTabCheckResultENT.DataBaseName = objvTabCheckResultENS.DataBaseName; //数据库名
objvTabCheckResultENT.FuncModuleAgcId = objvTabCheckResultENS.FuncModuleAgcId; //功能模块Id
objvTabCheckResultENT.FuncModuleName = objvTabCheckResultENS.FuncModuleName; //功能模块名称
objvTabCheckResultENT.TabCheckErrorTypeId = objvTabCheckResultENS.TabCheckErrorTypeId; //表检查错误类型Id
objvTabCheckResultENT.TabCheckErrorTypeName = objvTabCheckResultENS.TabCheckErrorTypeName; //表检查错误类型名
objvTabCheckResultENT.TabStateId = objvTabCheckResultENS.TabStateId; //表状态ID
objvTabCheckResultENT.OrderNum4Refer = objvTabCheckResultENS.OrderNum4Refer; //引用序号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTabCheckResultEN objvTabCheckResultEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.PrjId, 4, convTabCheckResult.PrjId);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.FldId, 8, convTabCheckResult.FldId);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.PrjName, 30, convTabCheckResult.PrjName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.PrjDataBaseName, 50, convTabCheckResult.PrjDataBaseName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.PrjDataBaseId, 4, convTabCheckResult.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.TabId, 8, convTabCheckResult.TabId);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.TabName, 100, convTabCheckResult.TabName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.TabCnName, 200, convTabCheckResult.TabCnName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.FldName, 50, convTabCheckResult.FldName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.ErrorLevelName, 50, convTabCheckResult.ErrorLevelName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.ErrorMsg, 5000, convTabCheckResult.ErrorMsg);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.CheckDate, 20, convTabCheckResult.CheckDate);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.CheckUser, 20, convTabCheckResult.CheckUser);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.Memo, 1000, convTabCheckResult.Memo);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.SqlDsTypeId, 2, convTabCheckResult.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.SqlDsTypeName, 20, convTabCheckResult.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.DataBaseName, 50, convTabCheckResult.DataBaseName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.FuncModuleAgcId, 8, convTabCheckResult.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.FuncModuleName, 30, convTabCheckResult.FuncModuleName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.TabCheckErrorTypeId, 2, convTabCheckResult.TabCheckErrorTypeId);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.TabCheckErrorTypeName, 30, convTabCheckResult.TabCheckErrorTypeName);
clsCheckSql.CheckFieldLen(objvTabCheckResultEN.TabStateId, 2, convTabCheckResult.TabStateId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.PrjId, convTabCheckResult.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.FldId, convTabCheckResult.FldId);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.PrjName, convTabCheckResult.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.PrjDataBaseName, convTabCheckResult.PrjDataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.PrjDataBaseId, convTabCheckResult.PrjDataBaseId);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.TabId, convTabCheckResult.TabId);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.TabName, convTabCheckResult.TabName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.TabCnName, convTabCheckResult.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.FldName, convTabCheckResult.FldName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.ErrorLevelName, convTabCheckResult.ErrorLevelName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.ErrorMsg, convTabCheckResult.ErrorMsg);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.CheckDate, convTabCheckResult.CheckDate);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.CheckUser, convTabCheckResult.CheckUser);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.Memo, convTabCheckResult.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.SqlDsTypeId, convTabCheckResult.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.SqlDsTypeName, convTabCheckResult.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.DataBaseName, convTabCheckResult.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.FuncModuleAgcId, convTabCheckResult.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.FuncModuleName, convTabCheckResult.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.TabCheckErrorTypeId, convTabCheckResult.TabCheckErrorTypeId);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.TabCheckErrorTypeName, convTabCheckResult.TabCheckErrorTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTabCheckResultEN.TabStateId, convTabCheckResult.TabStateId);
//检查外键字段长度
 objvTabCheckResultEN._IsCheckProperty = true;
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
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
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
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
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
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabCheckResultEN._CurrTabName);
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
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTabCheckResultEN._CurrTabName, strCondition);
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
 objSQL = clsvTabCheckResultDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}