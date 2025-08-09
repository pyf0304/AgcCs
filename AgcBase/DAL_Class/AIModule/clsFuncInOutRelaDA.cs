
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFuncInOutRelaDA
 表名:FuncInOutRela(00050407)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// 函数输入输出关系(FuncInOutRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFuncInOutRelaDA : clsCommBase4DA
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
 return clsFuncInOutRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFuncInOutRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFuncInOutRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFuncInOutRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFuncInOutRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FuncInOutRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTable_FuncInOutRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncInOutRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncInOutRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FuncInOutRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FuncInOutRela.* " + 
$"from FuncInOutRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FuncInOutRela.mId not in " + 
$"(Select top {intTop_In} FuncInOutRela.mId from FuncInOutRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncInOutRela where {1} and mId not in (Select top {2} mId from FuncInOutRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncInOutRela where {1} and mId not in (Select top {3} mId from FuncInOutRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FuncInOutRela.* " + 
$"from FuncInOutRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FuncInOutRela.mId not in " + 
$"(Select top {intTop_In} FuncInOutRela.mId from FuncInOutRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FuncInOutRela where {1} and mId not in (Select top {2} mId from FuncInOutRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FuncInOutRela where {1} and mId not in (Select top {3} mId from FuncInOutRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFuncInOutRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA:GetObjLst)", objException.Message));
}
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = TransNullToInt(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncInOutRelaDA: GetObjLst)", objException.Message));
}
objFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncInOutRelaEN);
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
public List<clsFuncInOutRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsFuncInOutRelaEN> arrObjLst = new List<clsFuncInOutRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = TransNullToInt(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFuncInOutRelaDA: GetObjLst)", objException.Message));
}
objFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFuncInOutRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFuncInOutRela(ref clsFuncInOutRelaEN objFuncInOutRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where mId = " + ""+ objFuncInOutRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFuncInOutRelaEN.mId = TransNullToInt(objDT.Rows[0][conFuncInOutRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFuncInOutRelaEN.FuncTabId = objDT.Rows[0][conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id(字段类型:char,字段长度:8,是否可空:True)
 objFuncInOutRelaEN.InFldIds = objDT.Rows[0][conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncInOutRelaEN.InFldNames = objDT.Rows[0][conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncInOutRelaEN.OutFldIds = objDT.Rows[0][conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncInOutRelaEN.OutFldNames = objDT.Rows[0][conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncInOutRelaEN.GcFuncName = objDT.Rows[0][conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objFuncInOutRelaEN.UpdDate = objDT.Rows[0][conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncInOutRelaEN.UpdUser = objDT.Rows[0][conFuncInOutRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncInOutRelaEN.Memo = objDT.Rows[0][conFuncInOutRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFuncInOutRelaDA: GetFuncInOutRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsFuncInOutRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
 objFuncInOutRelaEN.mId = Int32.Parse(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id(字段类型:char,字段长度:8,是否可空:True)
 objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s(字段类型:varchar,字段长度:1000,是否可空:True)
 objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFuncInOutRelaDA: GetObjBymId)", objException.Message));
}
return objFuncInOutRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFuncInOutRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN()
{
mId = TransNullToInt(objRow[conFuncInOutRela.mId].ToString().Trim()), //mId
FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(), //功能表Id
InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(), //输入字段Ids
InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(), //输入字段名s
OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(), //输出字段Ids
OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(), //输出字段名s
GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(), //GC函数名
UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim() //说明
};
objFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncInOutRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFuncInOutRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFuncInOutRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = TransNullToInt(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFuncInOutRelaDA: GetObjByDataRowFuncInOutRela)", objException.Message));
}
objFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncInOutRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFuncInOutRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFuncInOutRelaEN objFuncInOutRelaEN = new clsFuncInOutRelaEN();
try
{
objFuncInOutRelaEN.mId = TransNullToInt(objRow[conFuncInOutRela.mId].ToString().Trim()); //mId
objFuncInOutRelaEN.FuncTabId = objRow[conFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objFuncInOutRelaEN.InFldIds = objRow[conFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objFuncInOutRelaEN.InFldNames = objRow[conFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objFuncInOutRelaEN.OutFldIds = objRow[conFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objFuncInOutRelaEN.OutFldNames = objRow[conFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objFuncInOutRelaEN.GcFuncName = objRow[conFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objFuncInOutRelaEN.UpdDate = objRow[conFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objFuncInOutRelaEN.UpdUser = objRow[conFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objFuncInOutRelaEN.Memo = objRow[conFuncInOutRela.Memo] == DBNull.Value ? null : objRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFuncInOutRelaDA: GetObjByDataRow)", objException.Message));
}
objFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFuncInOutRelaEN;
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
objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncInOutRelaEN._CurrTabName, conFuncInOutRela.mId, 8, "");
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
objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFuncInOutRelaEN._CurrTabName, conFuncInOutRela.mId, 8, strPrefix);
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
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from FuncInOutRela where " + strCondition;
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
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from FuncInOutRela where " + strCondition;
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
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncInOutRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FuncInOutRela", strCondition))
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
objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FuncInOutRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFuncInOutRelaEN objFuncInOutRelaEN)
 {
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncInOutRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncInOutRela");
objRow = objDS.Tables["FuncInOutRela"].NewRow();
 if (objFuncInOutRelaEN.FuncTabId !=  "")
 {
objRow[conFuncInOutRela.FuncTabId] = objFuncInOutRelaEN.FuncTabId; //功能表Id
 }
 if (objFuncInOutRelaEN.InFldIds !=  "")
 {
objRow[conFuncInOutRela.InFldIds] = objFuncInOutRelaEN.InFldIds; //输入字段Ids
 }
 if (objFuncInOutRelaEN.InFldNames !=  "")
 {
objRow[conFuncInOutRela.InFldNames] = objFuncInOutRelaEN.InFldNames; //输入字段名s
 }
 if (objFuncInOutRelaEN.OutFldIds !=  "")
 {
objRow[conFuncInOutRela.OutFldIds] = objFuncInOutRelaEN.OutFldIds; //输出字段Ids
 }
 if (objFuncInOutRelaEN.OutFldNames !=  "")
 {
objRow[conFuncInOutRela.OutFldNames] = objFuncInOutRelaEN.OutFldNames; //输出字段名s
 }
 if (objFuncInOutRelaEN.GcFuncName !=  "")
 {
objRow[conFuncInOutRela.GcFuncName] = objFuncInOutRelaEN.GcFuncName; //GC函数名
 }
 if (objFuncInOutRelaEN.UpdDate !=  "")
 {
objRow[conFuncInOutRela.UpdDate] = objFuncInOutRelaEN.UpdDate; //修改日期
 }
 if (objFuncInOutRelaEN.UpdUser !=  "")
 {
objRow[conFuncInOutRela.UpdUser] = objFuncInOutRelaEN.UpdUser; //修改者
 }
 if (objFuncInOutRelaEN.Memo !=  "")
 {
objRow[conFuncInOutRela.Memo] = objFuncInOutRelaEN.Memo; //说明
 }
objDS.Tables[clsFuncInOutRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFuncInOutRelaEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncInOutRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFuncInOutRelaEN.FuncTabId !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.FuncTabId);
 var strFuncTabId = objFuncInOutRelaEN.FuncTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTabId + "'");
 }
 
 if (objFuncInOutRelaEN.InFldIds !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.InFldIds);
 var strInFldIds = objFuncInOutRelaEN.InFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldIds + "'");
 }
 
 if (objFuncInOutRelaEN.InFldNames !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.InFldNames);
 var strInFldNames = objFuncInOutRelaEN.InFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldNames + "'");
 }
 
 if (objFuncInOutRelaEN.OutFldIds !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.OutFldIds);
 var strOutFldIds = objFuncInOutRelaEN.OutFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldIds + "'");
 }
 
 if (objFuncInOutRelaEN.OutFldNames !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.OutFldNames);
 var strOutFldNames = objFuncInOutRelaEN.OutFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldNames + "'");
 }
 
 if (objFuncInOutRelaEN.GcFuncName !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.GcFuncName);
 var strGcFuncName = objFuncInOutRelaEN.GcFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcFuncName + "'");
 }
 
 if (objFuncInOutRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.UpdDate);
 var strUpdDate = objFuncInOutRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncInOutRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.UpdUser);
 var strUpdUser = objFuncInOutRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncInOutRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.Memo);
 var strMemo = objFuncInOutRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncInOutRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncInOutRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFuncInOutRelaEN.FuncTabId !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.FuncTabId);
 var strFuncTabId = objFuncInOutRelaEN.FuncTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTabId + "'");
 }
 
 if (objFuncInOutRelaEN.InFldIds !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.InFldIds);
 var strInFldIds = objFuncInOutRelaEN.InFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldIds + "'");
 }
 
 if (objFuncInOutRelaEN.InFldNames !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.InFldNames);
 var strInFldNames = objFuncInOutRelaEN.InFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldNames + "'");
 }
 
 if (objFuncInOutRelaEN.OutFldIds !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.OutFldIds);
 var strOutFldIds = objFuncInOutRelaEN.OutFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldIds + "'");
 }
 
 if (objFuncInOutRelaEN.OutFldNames !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.OutFldNames);
 var strOutFldNames = objFuncInOutRelaEN.OutFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldNames + "'");
 }
 
 if (objFuncInOutRelaEN.GcFuncName !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.GcFuncName);
 var strGcFuncName = objFuncInOutRelaEN.GcFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcFuncName + "'");
 }
 
 if (objFuncInOutRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.UpdDate);
 var strUpdDate = objFuncInOutRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncInOutRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.UpdUser);
 var strUpdUser = objFuncInOutRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncInOutRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.Memo);
 var strMemo = objFuncInOutRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncInOutRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFuncInOutRelaEN objFuncInOutRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncInOutRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFuncInOutRelaEN.FuncTabId !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.FuncTabId);
 var strFuncTabId = objFuncInOutRelaEN.FuncTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTabId + "'");
 }
 
 if (objFuncInOutRelaEN.InFldIds !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.InFldIds);
 var strInFldIds = objFuncInOutRelaEN.InFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldIds + "'");
 }
 
 if (objFuncInOutRelaEN.InFldNames !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.InFldNames);
 var strInFldNames = objFuncInOutRelaEN.InFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldNames + "'");
 }
 
 if (objFuncInOutRelaEN.OutFldIds !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.OutFldIds);
 var strOutFldIds = objFuncInOutRelaEN.OutFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldIds + "'");
 }
 
 if (objFuncInOutRelaEN.OutFldNames !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.OutFldNames);
 var strOutFldNames = objFuncInOutRelaEN.OutFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldNames + "'");
 }
 
 if (objFuncInOutRelaEN.GcFuncName !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.GcFuncName);
 var strGcFuncName = objFuncInOutRelaEN.GcFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcFuncName + "'");
 }
 
 if (objFuncInOutRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.UpdDate);
 var strUpdDate = objFuncInOutRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncInOutRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.UpdUser);
 var strUpdUser = objFuncInOutRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncInOutRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.Memo);
 var strMemo = objFuncInOutRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncInOutRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFuncInOutRelaEN objFuncInOutRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFuncInOutRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFuncInOutRelaEN.FuncTabId !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.FuncTabId);
 var strFuncTabId = objFuncInOutRelaEN.FuncTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTabId + "'");
 }
 
 if (objFuncInOutRelaEN.InFldIds !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.InFldIds);
 var strInFldIds = objFuncInOutRelaEN.InFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldIds + "'");
 }
 
 if (objFuncInOutRelaEN.InFldNames !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.InFldNames);
 var strInFldNames = objFuncInOutRelaEN.InFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInFldNames + "'");
 }
 
 if (objFuncInOutRelaEN.OutFldIds !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.OutFldIds);
 var strOutFldIds = objFuncInOutRelaEN.OutFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldIds + "'");
 }
 
 if (objFuncInOutRelaEN.OutFldNames !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.OutFldNames);
 var strOutFldNames = objFuncInOutRelaEN.OutFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutFldNames + "'");
 }
 
 if (objFuncInOutRelaEN.GcFuncName !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.GcFuncName);
 var strGcFuncName = objFuncInOutRelaEN.GcFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcFuncName + "'");
 }
 
 if (objFuncInOutRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.UpdDate);
 var strUpdDate = objFuncInOutRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFuncInOutRelaEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.UpdUser);
 var strUpdUser = objFuncInOutRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFuncInOutRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFuncInOutRela.Memo);
 var strMemo = objFuncInOutRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FuncInOutRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFuncInOutRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FuncInOutRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conFuncInOutRela.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFuncInOutRelaEN._CurrTabName ].NewRow();
objRow[conFuncInOutRela.FuncTabId] = oRow[conFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objRow[conFuncInOutRela.InFldIds] = oRow[conFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objRow[conFuncInOutRela.InFldNames] = oRow[conFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objRow[conFuncInOutRela.OutFldIds] = oRow[conFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objRow[conFuncInOutRela.OutFldNames] = oRow[conFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objRow[conFuncInOutRela.GcFuncName] = oRow[conFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objRow[conFuncInOutRela.UpdDate] = oRow[conFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objRow[conFuncInOutRela.UpdUser] = oRow[conFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objRow[conFuncInOutRela.Memo] = oRow[conFuncInOutRela.Memo].ToString().Trim(); //说明
 objDS.Tables[clsFuncInOutRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFuncInOutRelaEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncInOutRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from FuncInOutRela where mId = " + ""+ objFuncInOutRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFuncInOutRelaEN._CurrTabName);
if (objDS.Tables[clsFuncInOutRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objFuncInOutRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsFuncInOutRelaEN._CurrTabName].Rows[0];
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.FuncTabId))
 {
objRow[conFuncInOutRela.FuncTabId] = objFuncInOutRelaEN.FuncTabId; //功能表Id
 }
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldIds))
 {
objRow[conFuncInOutRela.InFldIds] = objFuncInOutRelaEN.InFldIds; //输入字段Ids
 }
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldNames))
 {
objRow[conFuncInOutRela.InFldNames] = objFuncInOutRelaEN.InFldNames; //输入字段名s
 }
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldIds))
 {
objRow[conFuncInOutRela.OutFldIds] = objFuncInOutRelaEN.OutFldIds; //输出字段Ids
 }
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldNames))
 {
objRow[conFuncInOutRela.OutFldNames] = objFuncInOutRelaEN.OutFldNames; //输出字段名s
 }
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.GcFuncName))
 {
objRow[conFuncInOutRela.GcFuncName] = objFuncInOutRelaEN.GcFuncName; //GC函数名
 }
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdDate))
 {
objRow[conFuncInOutRela.UpdDate] = objFuncInOutRelaEN.UpdDate; //修改日期
 }
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdUser))
 {
objRow[conFuncInOutRela.UpdUser] = objFuncInOutRelaEN.UpdUser; //修改者
 }
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.Memo))
 {
objRow[conFuncInOutRela.Memo] = objFuncInOutRelaEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsFuncInOutRelaEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncInOutRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FuncInOutRela Set ");
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.FuncTabId))
 {
 if (objFuncInOutRelaEN.FuncTabId !=  null)
 {
 var strFuncTabId = objFuncInOutRelaEN.FuncTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTabId, conFuncInOutRela.FuncTabId); //功能表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.FuncTabId); //功能表Id
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldIds))
 {
 if (objFuncInOutRelaEN.InFldIds !=  null)
 {
 var strInFldIds = objFuncInOutRelaEN.InFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInFldIds, conFuncInOutRela.InFldIds); //输入字段Ids
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.InFldIds); //输入字段Ids
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldNames))
 {
 if (objFuncInOutRelaEN.InFldNames !=  null)
 {
 var strInFldNames = objFuncInOutRelaEN.InFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInFldNames, conFuncInOutRela.InFldNames); //输入字段名s
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.InFldNames); //输入字段名s
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldIds))
 {
 if (objFuncInOutRelaEN.OutFldIds !=  null)
 {
 var strOutFldIds = objFuncInOutRelaEN.OutFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldIds, conFuncInOutRela.OutFldIds); //输出字段Ids
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.OutFldIds); //输出字段Ids
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldNames))
 {
 if (objFuncInOutRelaEN.OutFldNames !=  null)
 {
 var strOutFldNames = objFuncInOutRelaEN.OutFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldNames, conFuncInOutRela.OutFldNames); //输出字段名s
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.OutFldNames); //输出字段名s
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.GcFuncName))
 {
 if (objFuncInOutRelaEN.GcFuncName !=  null)
 {
 var strGcFuncName = objFuncInOutRelaEN.GcFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcFuncName, conFuncInOutRela.GcFuncName); //GC函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.GcFuncName); //GC函数名
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdDate))
 {
 if (objFuncInOutRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncInOutRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFuncInOutRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.UpdDate); //修改日期
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdUser))
 {
 if (objFuncInOutRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncInOutRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFuncInOutRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.UpdUser); //修改者
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.Memo))
 {
 if (objFuncInOutRelaEN.Memo !=  null)
 {
 var strMemo = objFuncInOutRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFuncInOutRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFuncInOutRelaEN.mId); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFuncInOutRelaEN objFuncInOutRelaEN, string strCondition)
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncInOutRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncInOutRela Set ");
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.FuncTabId))
 {
 if (objFuncInOutRelaEN.FuncTabId !=  null)
 {
 var strFuncTabId = objFuncInOutRelaEN.FuncTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTabId = '{0}',", strFuncTabId); //功能表Id
 }
 else
 {
 sbSQL.Append(" FuncTabId = null,"); //功能表Id
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldIds))
 {
 if (objFuncInOutRelaEN.InFldIds !=  null)
 {
 var strInFldIds = objFuncInOutRelaEN.InFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InFldIds = '{0}',", strInFldIds); //输入字段Ids
 }
 else
 {
 sbSQL.Append(" InFldIds = null,"); //输入字段Ids
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldNames))
 {
 if (objFuncInOutRelaEN.InFldNames !=  null)
 {
 var strInFldNames = objFuncInOutRelaEN.InFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InFldNames = '{0}',", strInFldNames); //输入字段名s
 }
 else
 {
 sbSQL.Append(" InFldNames = null,"); //输入字段名s
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldIds))
 {
 if (objFuncInOutRelaEN.OutFldIds !=  null)
 {
 var strOutFldIds = objFuncInOutRelaEN.OutFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldIds = '{0}',", strOutFldIds); //输出字段Ids
 }
 else
 {
 sbSQL.Append(" OutFldIds = null,"); //输出字段Ids
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldNames))
 {
 if (objFuncInOutRelaEN.OutFldNames !=  null)
 {
 var strOutFldNames = objFuncInOutRelaEN.OutFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldNames = '{0}',", strOutFldNames); //输出字段名s
 }
 else
 {
 sbSQL.Append(" OutFldNames = null,"); //输出字段名s
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.GcFuncName))
 {
 if (objFuncInOutRelaEN.GcFuncName !=  null)
 {
 var strGcFuncName = objFuncInOutRelaEN.GcFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcFuncName = '{0}',", strGcFuncName); //GC函数名
 }
 else
 {
 sbSQL.Append(" GcFuncName = null,"); //GC函数名
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdDate))
 {
 if (objFuncInOutRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncInOutRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdUser))
 {
 if (objFuncInOutRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncInOutRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.Memo))
 {
 if (objFuncInOutRelaEN.Memo !=  null)
 {
 var strMemo = objFuncInOutRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFuncInOutRelaEN objFuncInOutRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncInOutRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncInOutRela Set ");
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.FuncTabId))
 {
 if (objFuncInOutRelaEN.FuncTabId !=  null)
 {
 var strFuncTabId = objFuncInOutRelaEN.FuncTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTabId = '{0}',", strFuncTabId); //功能表Id
 }
 else
 {
 sbSQL.Append(" FuncTabId = null,"); //功能表Id
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldIds))
 {
 if (objFuncInOutRelaEN.InFldIds !=  null)
 {
 var strInFldIds = objFuncInOutRelaEN.InFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InFldIds = '{0}',", strInFldIds); //输入字段Ids
 }
 else
 {
 sbSQL.Append(" InFldIds = null,"); //输入字段Ids
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldNames))
 {
 if (objFuncInOutRelaEN.InFldNames !=  null)
 {
 var strInFldNames = objFuncInOutRelaEN.InFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InFldNames = '{0}',", strInFldNames); //输入字段名s
 }
 else
 {
 sbSQL.Append(" InFldNames = null,"); //输入字段名s
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldIds))
 {
 if (objFuncInOutRelaEN.OutFldIds !=  null)
 {
 var strOutFldIds = objFuncInOutRelaEN.OutFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldIds = '{0}',", strOutFldIds); //输出字段Ids
 }
 else
 {
 sbSQL.Append(" OutFldIds = null,"); //输出字段Ids
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldNames))
 {
 if (objFuncInOutRelaEN.OutFldNames !=  null)
 {
 var strOutFldNames = objFuncInOutRelaEN.OutFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutFldNames = '{0}',", strOutFldNames); //输出字段名s
 }
 else
 {
 sbSQL.Append(" OutFldNames = null,"); //输出字段名s
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.GcFuncName))
 {
 if (objFuncInOutRelaEN.GcFuncName !=  null)
 {
 var strGcFuncName = objFuncInOutRelaEN.GcFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcFuncName = '{0}',", strGcFuncName); //GC函数名
 }
 else
 {
 sbSQL.Append(" GcFuncName = null,"); //GC函数名
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdDate))
 {
 if (objFuncInOutRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncInOutRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdUser))
 {
 if (objFuncInOutRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncInOutRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.Memo))
 {
 if (objFuncInOutRelaEN.Memo !=  null)
 {
 var strMemo = objFuncInOutRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFuncInOutRelaEN objFuncInOutRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFuncInOutRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFuncInOutRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFuncInOutRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FuncInOutRela Set ");
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.FuncTabId))
 {
 if (objFuncInOutRelaEN.FuncTabId !=  null)
 {
 var strFuncTabId = objFuncInOutRelaEN.FuncTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTabId, conFuncInOutRela.FuncTabId); //功能表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.FuncTabId); //功能表Id
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldIds))
 {
 if (objFuncInOutRelaEN.InFldIds !=  null)
 {
 var strInFldIds = objFuncInOutRelaEN.InFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInFldIds, conFuncInOutRela.InFldIds); //输入字段Ids
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.InFldIds); //输入字段Ids
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.InFldNames))
 {
 if (objFuncInOutRelaEN.InFldNames !=  null)
 {
 var strInFldNames = objFuncInOutRelaEN.InFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInFldNames, conFuncInOutRela.InFldNames); //输入字段名s
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.InFldNames); //输入字段名s
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldIds))
 {
 if (objFuncInOutRelaEN.OutFldIds !=  null)
 {
 var strOutFldIds = objFuncInOutRelaEN.OutFldIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldIds, conFuncInOutRela.OutFldIds); //输出字段Ids
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.OutFldIds); //输出字段Ids
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.OutFldNames))
 {
 if (objFuncInOutRelaEN.OutFldNames !=  null)
 {
 var strOutFldNames = objFuncInOutRelaEN.OutFldNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutFldNames, conFuncInOutRela.OutFldNames); //输出字段名s
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.OutFldNames); //输出字段名s
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.GcFuncName))
 {
 if (objFuncInOutRelaEN.GcFuncName !=  null)
 {
 var strGcFuncName = objFuncInOutRelaEN.GcFuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcFuncName, conFuncInOutRela.GcFuncName); //GC函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.GcFuncName); //GC函数名
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdDate))
 {
 if (objFuncInOutRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objFuncInOutRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFuncInOutRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.UpdDate); //修改日期
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.UpdUser))
 {
 if (objFuncInOutRelaEN.UpdUser !=  null)
 {
 var strUpdUser = objFuncInOutRelaEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFuncInOutRela.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.UpdUser); //修改者
 }
 }
 
 if (objFuncInOutRelaEN.IsUpdated(conFuncInOutRela.Memo))
 {
 if (objFuncInOutRelaEN.Memo !=  null)
 {
 var strMemo = objFuncInOutRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFuncInOutRela.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFuncInOutRela.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objFuncInOutRelaEN.mId); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("FuncInOutRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
//删除FuncInOutRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncInOutRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFuncInOutRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除FuncInOutRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncInOutRela where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
//删除FuncInOutRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FuncInOutRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFuncInOutRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: DelFuncInOutRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncInOutRela where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelFuncInOutRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFuncInOutRelaDA: DelFuncInOutRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FuncInOutRela where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objFuncInOutRelaENS">源对象</param>
 /// <param name = "objFuncInOutRelaENT">目标对象</param>
public void CopyTo(clsFuncInOutRelaEN objFuncInOutRelaENS, clsFuncInOutRelaEN objFuncInOutRelaENT)
{
objFuncInOutRelaENT.mId = objFuncInOutRelaENS.mId; //mId
objFuncInOutRelaENT.FuncTabId = objFuncInOutRelaENS.FuncTabId; //功能表Id
objFuncInOutRelaENT.InFldIds = objFuncInOutRelaENS.InFldIds; //输入字段Ids
objFuncInOutRelaENT.InFldNames = objFuncInOutRelaENS.InFldNames; //输入字段名s
objFuncInOutRelaENT.OutFldIds = objFuncInOutRelaENS.OutFldIds; //输出字段Ids
objFuncInOutRelaENT.OutFldNames = objFuncInOutRelaENS.OutFldNames; //输出字段名s
objFuncInOutRelaENT.GcFuncName = objFuncInOutRelaENS.GcFuncName; //GC函数名
objFuncInOutRelaENT.UpdDate = objFuncInOutRelaENS.UpdDate; //修改日期
objFuncInOutRelaENT.UpdUser = objFuncInOutRelaENS.UpdUser; //修改者
objFuncInOutRelaENT.Memo = objFuncInOutRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.FuncTabId, 8, conFuncInOutRela.FuncTabId);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.InFldIds, 1000, conFuncInOutRela.InFldIds);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.InFldNames, 1000, conFuncInOutRela.InFldNames);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.OutFldIds, 1000, conFuncInOutRela.OutFldIds);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.OutFldNames, 1000, conFuncInOutRela.OutFldNames);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.GcFuncName, 50, conFuncInOutRela.GcFuncName);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.UpdDate, 20, conFuncInOutRela.UpdDate);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.UpdUser, 20, conFuncInOutRela.UpdUser);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.Memo, 1000, conFuncInOutRela.Memo);
//检查字段外键固定长度
 objFuncInOutRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.FuncTabId, 8, conFuncInOutRela.FuncTabId);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.InFldIds, 1000, conFuncInOutRela.InFldIds);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.InFldNames, 1000, conFuncInOutRela.InFldNames);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.OutFldIds, 1000, conFuncInOutRela.OutFldIds);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.OutFldNames, 1000, conFuncInOutRela.OutFldNames);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.GcFuncName, 50, conFuncInOutRela.GcFuncName);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.UpdDate, 20, conFuncInOutRela.UpdDate);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.UpdUser, 20, conFuncInOutRela.UpdUser);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.Memo, 1000, conFuncInOutRela.Memo);
//检查外键字段长度
 objFuncInOutRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.FuncTabId, 8, conFuncInOutRela.FuncTabId);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.InFldIds, 1000, conFuncInOutRela.InFldIds);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.InFldNames, 1000, conFuncInOutRela.InFldNames);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.OutFldIds, 1000, conFuncInOutRela.OutFldIds);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.OutFldNames, 1000, conFuncInOutRela.OutFldNames);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.GcFuncName, 50, conFuncInOutRela.GcFuncName);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.UpdDate, 20, conFuncInOutRela.UpdDate);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.UpdUser, 20, conFuncInOutRela.UpdUser);
clsCheckSql.CheckFieldLen(objFuncInOutRelaEN.Memo, 1000, conFuncInOutRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.FuncTabId, conFuncInOutRela.FuncTabId);
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.InFldIds, conFuncInOutRela.InFldIds);
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.InFldNames, conFuncInOutRela.InFldNames);
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.OutFldIds, conFuncInOutRela.OutFldIds);
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.OutFldNames, conFuncInOutRela.OutFldNames);
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.GcFuncName, conFuncInOutRela.GcFuncName);
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.UpdDate, conFuncInOutRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.UpdUser, conFuncInOutRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFuncInOutRelaEN.Memo, conFuncInOutRela.Memo);
//检查外键字段长度
 objFuncInOutRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FuncInOutRela(函数输入输出关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFuncInOutRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFuncInOutRelaEN objFuncInOutRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objFuncInOutRelaEN.FuncTabId == null)
{
 sbCondition.AppendFormat(" and FuncTabId is null");
}
else
{
 sbCondition.AppendFormat(" and FuncTabId = '{0}'", objFuncInOutRelaEN.FuncTabId);
}
 if (objFuncInOutRelaEN.GcFuncName == null)
{
 sbCondition.AppendFormat(" and GcFuncName is null");
}
else
{
 sbCondition.AppendFormat(" and GcFuncName = '{0}'", objFuncInOutRelaEN.GcFuncName);
}
return sbCondition.ToString();
}

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
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
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
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
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
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncInOutRelaEN._CurrTabName);
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
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFuncInOutRelaEN._CurrTabName, strCondition);
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
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFuncInOutRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}