
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcelSetDA
 表名:vExportExcelSet(00050238)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:14
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
 /// v导出Excel设置(vExportExcelSet)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvExportExcelSetDA : clsCommBase4DA
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
 return clsvExportExcelSetEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvExportExcelSetEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvExportExcelSetEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvExportExcelSetEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvExportExcelSetEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdExportExcel4Users)
{
strIdExportExcel4Users = strIdExportExcel4Users.Replace("'", "''");
if (strIdExportExcel4Users.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vExportExcelSet中,检查关键字,长度不正确!(clsvExportExcelSetDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdExportExcel4Users)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vExportExcelSet中,关键字不能为空 或 null!(clsvExportExcelSetDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdExportExcel4Users);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvExportExcelSetDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcelSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vExportExcelSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTable_vExportExcelSet)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcelSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcelSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExportExcelSet where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExportExcelSet where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vExportExcelSet where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vExportExcelSet.* " + 
$"from vExportExcelSet " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vExportExcelSet.IdExportExcel4Users not in " + 
$"(Select top {intTop_In} vExportExcelSet.IdExportExcel4Users from vExportExcelSet " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExportExcelSet where {1} and IdExportExcel4Users not in (Select top {2} IdExportExcel4Users from vExportExcelSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExportExcelSet where {1} and IdExportExcel4Users not in (Select top {3} IdExportExcel4Users from vExportExcelSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vExportExcelSet.* " + 
$"from vExportExcelSet " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vExportExcelSet.IdExportExcel4Users not in " + 
$"(Select top {intTop_In} vExportExcelSet.IdExportExcel4Users from vExportExcelSet " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExportExcelSet where {1} and IdExportExcel4Users not in (Select top {2} IdExportExcel4Users from vExportExcelSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExportExcelSet where {1} and IdExportExcel4Users not in (Select top {3} IdExportExcel4Users from vExportExcelSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvExportExcelSetEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvExportExcelSetDA:GetObjLst)", objException.Message));
}
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcelSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = TransNullToBool(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvExportExcelSetDA: GetObjLst)", objException.Message));
}
objvExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvExportExcelSetEN);
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
public List<clsvExportExcelSetEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvExportExcelSetDA:GetObjLstByTabName)", objException.Message));
}
List<clsvExportExcelSetEN> arrObjLst = new List<clsvExportExcelSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = TransNullToBool(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvExportExcelSetDA: GetObjLst)", objException.Message));
}
objvExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvExportExcelSetEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvExportExcelSetEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvExportExcelSet(ref clsvExportExcelSetEN objvExportExcelSetEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcelSet where IdExportExcel4Users = " + "'"+ objvExportExcelSetEN.IdExportExcel4Users+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvExportExcelSetEN.IdExportExcel4Users = objDT.Rows[0][convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号(字段类型:char,字段长度:8,是否可空:True)
 objvExportExcelSetEN.ViewName = objDT.Rows[0][convExportExcelSet.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcelSetEN.TabName = objDT.Rows[0][convExportExcelSet.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcelSetEN.IsDefaultUser = TransNullToBool(objDT.Rows[0][convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户(字段类型:bit,字段长度:1,是否可空:False)
 objvExportExcelSetEN.UserName = objDT.Rows[0][convExportExcelSet.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvExportExcelSetEN.ExportFileName = objDT.Rows[0][convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcelSetEN.UpdUserId = objDT.Rows[0][convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvExportExcelSetEN.UpdDate = objDT.Rows[0][convExportExcelSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvExportExcelSetEN.Memo = objDT.Rows[0][convExportExcelSet.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvExportExcelSetEN.UserId = objDT.Rows[0][convExportExcelSet.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvExportExcelSetEN.ViewTabName = objDT.Rows[0][convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName(字段类型:varchar,字段长度:101,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvExportExcelSetDA: GetvExportExcelSet)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public clsvExportExcelSetEN GetObjByIdExportExcel4Users(string strIdExportExcel4Users)
{
CheckPrimaryKey(strIdExportExcel4Users);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcelSet where IdExportExcel4Users = " + "'"+ strIdExportExcel4Users+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
 objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号(字段类型:char,字段长度:8,是否可空:True)
 objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户(字段类型:bit,字段长度:1,是否可空:False)
 objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName(字段类型:varchar,字段长度:101,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvExportExcelSetDA: GetObjByIdExportExcel4Users)", objException.Message));
}
return objvExportExcelSetEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvExportExcelSetEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvExportExcelSetDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcelSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN()
{
IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(), //导出Excel用户字段流水号
ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(), //界面名称
TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(), //表名
IsDefaultUser = TransNullToBool(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()), //是否缺省用户
UserName = objRow[convExportExcelSet.UserName].ToString().Trim(), //用户名
ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(), //导出文件名
UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(), //说明
UserId = objRow[convExportExcelSet.UserId].ToString().Trim(), //用户Id
ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim() //ViewTabName
};
objvExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExportExcelSetEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvExportExcelSetDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvExportExcelSetEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = TransNullToBool(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvExportExcelSetDA: GetObjByDataRowvExportExcelSet)", objException.Message));
}
objvExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExportExcelSetEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvExportExcelSetEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvExportExcelSetEN objvExportExcelSetEN = new clsvExportExcelSetEN();
try
{
objvExportExcelSetEN.IdExportExcel4Users = objRow[convExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcelSetEN.ViewName = objRow[convExportExcelSet.ViewName] == DBNull.Value ? null : objRow[convExportExcelSet.ViewName].ToString().Trim(); //界面名称
objvExportExcelSetEN.TabName = objRow[convExportExcelSet.TabName] == DBNull.Value ? null : objRow[convExportExcelSet.TabName].ToString().Trim(); //表名
objvExportExcelSetEN.IsDefaultUser = TransNullToBool(objRow[convExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcelSetEN.UserName = objRow[convExportExcelSet.UserName].ToString().Trim(); //用户名
objvExportExcelSetEN.ExportFileName = objRow[convExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcelSetEN.UpdUserId = objRow[convExportExcelSet.UpdUserId] == DBNull.Value ? null : objRow[convExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcelSetEN.UpdDate = objRow[convExportExcelSet.UpdDate] == DBNull.Value ? null : objRow[convExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objvExportExcelSetEN.Memo = objRow[convExportExcelSet.Memo] == DBNull.Value ? null : objRow[convExportExcelSet.Memo].ToString().Trim(); //说明
objvExportExcelSetEN.UserId = objRow[convExportExcelSet.UserId].ToString().Trim(); //用户Id
objvExportExcelSetEN.ViewTabName = objRow[convExportExcelSet.ViewTabName].ToString().Trim(); //ViewTabName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvExportExcelSetDA: GetObjByDataRow)", objException.Message));
}
objvExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExportExcelSetEN;
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
objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvExportExcelSetEN._CurrTabName, convExportExcelSet.IdExportExcel4Users, 8, "");
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
objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvExportExcelSetEN._CurrTabName, convExportExcelSet.IdExportExcel4Users, 8, strPrefix);
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
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdExportExcel4Users from vExportExcelSet where " + strCondition;
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
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdExportExcel4Users from vExportExcelSet where " + strCondition;
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
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdExportExcel4Users)
{
CheckPrimaryKey(strIdExportExcel4Users);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vExportExcelSet", "IdExportExcel4Users = " + "'"+ strIdExportExcel4Users+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvExportExcelSetDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vExportExcelSet", strCondition))
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
objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vExportExcelSet");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvExportExcelSetENS">源对象</param>
 /// <param name = "objvExportExcelSetENT">目标对象</param>
public void CopyTo(clsvExportExcelSetEN objvExportExcelSetENS, clsvExportExcelSetEN objvExportExcelSetENT)
{
objvExportExcelSetENT.IdExportExcel4Users = objvExportExcelSetENS.IdExportExcel4Users; //导出Excel用户字段流水号
objvExportExcelSetENT.ViewName = objvExportExcelSetENS.ViewName; //界面名称
objvExportExcelSetENT.TabName = objvExportExcelSetENS.TabName; //表名
objvExportExcelSetENT.IsDefaultUser = objvExportExcelSetENS.IsDefaultUser; //是否缺省用户
objvExportExcelSetENT.UserName = objvExportExcelSetENS.UserName; //用户名
objvExportExcelSetENT.ExportFileName = objvExportExcelSetENS.ExportFileName; //导出文件名
objvExportExcelSetENT.UpdUserId = objvExportExcelSetENS.UpdUserId; //修改用户Id
objvExportExcelSetENT.UpdDate = objvExportExcelSetENS.UpdDate; //修改日期
objvExportExcelSetENT.Memo = objvExportExcelSetENS.Memo; //说明
objvExportExcelSetENT.UserId = objvExportExcelSetENS.UserId; //用户Id
objvExportExcelSetENT.ViewTabName = objvExportExcelSetENS.ViewTabName; //ViewTabName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvExportExcelSetEN objvExportExcelSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.IdExportExcel4Users, 8, convExportExcelSet.IdExportExcel4Users);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.ViewName, 100, convExportExcelSet.ViewName);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.TabName, 100, convExportExcelSet.TabName);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.UserName, 30, convExportExcelSet.UserName);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.ExportFileName, 100, convExportExcelSet.ExportFileName);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.UpdUserId, 20, convExportExcelSet.UpdUserId);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.UpdDate, 20, convExportExcelSet.UpdDate);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.Memo, 1000, convExportExcelSet.Memo);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.UserId, 18, convExportExcelSet.UserId);
clsCheckSql.CheckFieldLen(objvExportExcelSetEN.ViewTabName, 101, convExportExcelSet.ViewTabName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.IdExportExcel4Users, convExportExcelSet.IdExportExcel4Users);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.ViewName, convExportExcelSet.ViewName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.TabName, convExportExcelSet.TabName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.UserName, convExportExcelSet.UserName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.ExportFileName, convExportExcelSet.ExportFileName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.UpdUserId, convExportExcelSet.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.UpdDate, convExportExcelSet.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.Memo, convExportExcelSet.Memo);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.UserId, convExportExcelSet.UserId);
clsCheckSql.CheckSqlInjection4Field(objvExportExcelSetEN.ViewTabName, convExportExcelSet.ViewTabName);
//检查外键字段长度
 objvExportExcelSetEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdExportExcel4Users()
{
//获取某学院所有专业信息
string strSQL = "select IdExportExcel4Users, ViewTabName from vExportExcelSet ";
 clsSpecSQLforSql mySql = clsvExportExcelSetDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
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
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
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
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvExportExcelSetEN._CurrTabName);
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
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvExportExcelSetEN._CurrTabName, strCondition);
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
 objSQL = clsvExportExcelSetDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}