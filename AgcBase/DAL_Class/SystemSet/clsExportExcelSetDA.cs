
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcelSetDA
 表名:ExportExcelSet(00050240)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:38
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 导出Excel设置(ExportExcelSet)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsExportExcelSetDA : clsCommBase4DA
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
 return clsExportExcelSetEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsExportExcelSetEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsExportExcelSetEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsExportExcelSetEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsExportExcelSetEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:ExportExcelSet中,检查关键字,长度不正确!(clsExportExcelSetDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdExportExcel4Users)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ExportExcelSet中,关键字不能为空 或 null!(clsExportExcelSetDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdExportExcel4Users);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsExportExcelSetDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ExportExcelSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTable_ExportExcelSet)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExportExcelSet where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExportExcelSet where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ExportExcelSet where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ExportExcelSet.* " + 
$"from ExportExcelSet " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ExportExcelSet.IdExportExcel4Users not in " + 
$"(Select top {intTop_In} ExportExcelSet.IdExportExcel4Users from ExportExcelSet " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExportExcelSet where {1} and IdExportExcel4Users not in (Select top {2} IdExportExcel4Users from ExportExcelSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExportExcelSet where {1} and IdExportExcel4Users not in (Select top {3} IdExportExcel4Users from ExportExcelSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsExportExcelSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ExportExcelSet.* " + 
$"from ExportExcelSet " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ExportExcelSet.IdExportExcel4Users not in " + 
$"(Select top {intTop_In} ExportExcelSet.IdExportExcel4Users from ExportExcelSet " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExportExcelSet where {1} and IdExportExcel4Users not in (Select top {2} IdExportExcel4Users from ExportExcelSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExportExcelSet where {1} and IdExportExcel4Users not in (Select top {3} IdExportExcel4Users from ExportExcelSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsExportExcelSetEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsExportExcelSetDA:GetObjLst)", objException.Message));
}
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = TransNullToBool(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsExportExcelSetDA: GetObjLst)", objException.Message));
}
objExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objExportExcelSetEN);
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
public List<clsExportExcelSetEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsExportExcelSetDA:GetObjLstByTabName)", objException.Message));
}
List<clsExportExcelSetEN> arrObjLst = new List<clsExportExcelSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = TransNullToBool(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsExportExcelSetDA: GetObjLst)", objException.Message));
}
objExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objExportExcelSetEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetExportExcelSet(ref clsExportExcelSetEN objExportExcelSetEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where IdExportExcel4Users = " + "'"+ objExportExcelSetEN.IdExportExcel4Users+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objExportExcelSetEN.IdExportExcel4Users = objDT.Rows[0][conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号(字段类型:char,字段长度:8,是否可空:True)
 objExportExcelSetEN.ViewName = objDT.Rows[0][conExportExcelSet.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objExportExcelSetEN.TabName = objDT.Rows[0][conExportExcelSet.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objExportExcelSetEN.UserId = objDT.Rows[0][conExportExcelSet.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objExportExcelSetEN.IsDefaultUser = TransNullToBool(objDT.Rows[0][conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户(字段类型:bit,字段长度:1,是否可空:False)
 objExportExcelSetEN.ExportFileName = objDT.Rows[0][conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名(字段类型:varchar,字段长度:100,是否可空:False)
 objExportExcelSetEN.UpdDate = objDT.Rows[0][conExportExcelSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objExportExcelSetEN.UpdUserId = objDT.Rows[0][conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objExportExcelSetEN.Memo = objDT.Rows[0][conExportExcelSet.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsExportExcelSetDA: GetExportExcelSet)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">表关键字</param>
 /// <returns>表对象</returns>
public clsExportExcelSetEN GetObjByIdExportExcel4Users(string strIdExportExcel4Users)
{
CheckPrimaryKey(strIdExportExcel4Users);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where IdExportExcel4Users = " + "'"+ strIdExportExcel4Users+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
 objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号(字段类型:char,字段长度:8,是否可空:True)
 objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objExportExcelSetEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户(字段类型:bit,字段长度:1,是否可空:False)
 objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名(字段类型:varchar,字段长度:100,是否可空:False)
 objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsExportExcelSetDA: GetObjByIdExportExcel4Users)", objException.Message));
}
return objExportExcelSetEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsExportExcelSetEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsExportExcelSetDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN()
{
IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(), //导出Excel用户字段流水号
ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(), //界面名称
TabName = objRow[conExportExcelSet.TabName].ToString().Trim(), //表名
UserId = objRow[conExportExcelSet.UserId].ToString().Trim(), //用户Id
IsDefaultUser = TransNullToBool(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()), //是否缺省用户
ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(), //导出文件名
UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim() //说明
};
objExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExportExcelSetEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsExportExcelSetDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsExportExcelSetEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = TransNullToBool(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsExportExcelSetDA: GetObjByDataRowExportExcelSet)", objException.Message));
}
objExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExportExcelSetEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsExportExcelSetEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsExportExcelSetEN objExportExcelSetEN = new clsExportExcelSetEN();
try
{
objExportExcelSetEN.IdExportExcel4Users = objRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcelSetEN.ViewName = objRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objExportExcelSetEN.TabName = objRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objExportExcelSetEN.UserId = objRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objExportExcelSetEN.IsDefaultUser = TransNullToBool(objRow[conExportExcelSet.IsDefaultUser].ToString().Trim()); //是否缺省用户
objExportExcelSetEN.ExportFileName = objRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objExportExcelSetEN.UpdDate = objRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objExportExcelSetEN.UpdUserId = objRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcelSetEN.Memo = objRow[conExportExcelSet.Memo] == DBNull.Value ? null : objRow[conExportExcelSet.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsExportExcelSetDA: GetObjByDataRow)", objException.Message));
}
objExportExcelSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExportExcelSetEN;
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
objSQL = clsExportExcelSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsExportExcelSetEN._CurrTabName, conExportExcelSet.IdExportExcel4Users, 8, "");
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
objSQL = clsExportExcelSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsExportExcelSetEN._CurrTabName, conExportExcelSet.IdExportExcel4Users, 8, strPrefix);
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdExportExcel4Users from ExportExcelSet where " + strCondition;
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdExportExcel4Users from ExportExcelSet where " + strCondition;
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ExportExcelSet", "IdExportExcel4Users = " + "'"+ strIdExportExcel4Users+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsExportExcelSetDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ExportExcelSet", strCondition))
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
objSQL = clsExportExcelSetDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ExportExcelSet");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsExportExcelSetEN objExportExcelSetEN)
 {
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcelSetEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ExportExcelSet");
objRow = objDS.Tables["ExportExcelSet"].NewRow();
objRow[conExportExcelSet.IdExportExcel4Users] = objExportExcelSetEN.IdExportExcel4Users; //导出Excel用户字段流水号
objRow[conExportExcelSet.ViewName] = objExportExcelSetEN.ViewName; //界面名称
objRow[conExportExcelSet.TabName] = objExportExcelSetEN.TabName; //表名
objRow[conExportExcelSet.UserId] = objExportExcelSetEN.UserId; //用户Id
objRow[conExportExcelSet.IsDefaultUser] = objExportExcelSetEN.IsDefaultUser; //是否缺省用户
objRow[conExportExcelSet.ExportFileName] = objExportExcelSetEN.ExportFileName; //导出文件名
objRow[conExportExcelSet.UpdDate] = objExportExcelSetEN.UpdDate; //修改日期
objRow[conExportExcelSet.UpdUserId] = objExportExcelSetEN.UpdUserId; //修改用户Id
 if (objExportExcelSetEN.Memo !=  "")
 {
objRow[conExportExcelSet.Memo] = objExportExcelSetEN.Memo; //说明
 }
objDS.Tables[clsExportExcelSetEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsExportExcelSetEN._CurrTabName);
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
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsExportExcelSetEN objExportExcelSetEN)
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcelSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objExportExcelSetEN.IdExportExcel4Users !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.IdExportExcel4Users);
 var strIdExportExcel4Users = objExportExcelSetEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExportExcel4Users + "'");
 }
 
 if (objExportExcelSetEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.ViewName);
 var strViewName = objExportExcelSetEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objExportExcelSetEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.TabName);
 var strTabName = objExportExcelSetEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objExportExcelSetEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UserId);
 var strUserId = objExportExcelSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conExportExcelSet.IsDefaultUser);
 arrValueListForInsert.Add("'" + (objExportExcelSetEN.IsDefaultUser  ==  false ? "0" : "1") + "'");
 
 if (objExportExcelSetEN.ExportFileName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.ExportFileName);
 var strExportFileName = objExportExcelSetEN.ExportFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportFileName + "'");
 }
 
 if (objExportExcelSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UpdDate);
 var strUpdDate = objExportExcelSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExportExcelSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UpdUserId);
 var strUpdUserId = objExportExcelSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objExportExcelSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.Memo);
 var strMemo = objExportExcelSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExportExcelSet");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsExportExcelSetEN objExportExcelSetEN)
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcelSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objExportExcelSetEN.IdExportExcel4Users !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.IdExportExcel4Users);
 var strIdExportExcel4Users = objExportExcelSetEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExportExcel4Users + "'");
 }
 
 if (objExportExcelSetEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.ViewName);
 var strViewName = objExportExcelSetEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objExportExcelSetEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.TabName);
 var strTabName = objExportExcelSetEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objExportExcelSetEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UserId);
 var strUserId = objExportExcelSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conExportExcelSet.IsDefaultUser);
 arrValueListForInsert.Add("'" + (objExportExcelSetEN.IsDefaultUser  ==  false ? "0" : "1") + "'");
 
 if (objExportExcelSetEN.ExportFileName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.ExportFileName);
 var strExportFileName = objExportExcelSetEN.ExportFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportFileName + "'");
 }
 
 if (objExportExcelSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UpdDate);
 var strUpdDate = objExportExcelSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExportExcelSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UpdUserId);
 var strUpdUserId = objExportExcelSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objExportExcelSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.Memo);
 var strMemo = objExportExcelSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExportExcelSet");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objExportExcelSetEN.IdExportExcel4Users;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsExportExcelSetEN objExportExcelSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcelSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objExportExcelSetEN.IdExportExcel4Users !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.IdExportExcel4Users);
 var strIdExportExcel4Users = objExportExcelSetEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExportExcel4Users + "'");
 }
 
 if (objExportExcelSetEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.ViewName);
 var strViewName = objExportExcelSetEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objExportExcelSetEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.TabName);
 var strTabName = objExportExcelSetEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objExportExcelSetEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UserId);
 var strUserId = objExportExcelSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conExportExcelSet.IsDefaultUser);
 arrValueListForInsert.Add("'" + (objExportExcelSetEN.IsDefaultUser  ==  false ? "0" : "1") + "'");
 
 if (objExportExcelSetEN.ExportFileName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.ExportFileName);
 var strExportFileName = objExportExcelSetEN.ExportFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportFileName + "'");
 }
 
 if (objExportExcelSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UpdDate);
 var strUpdDate = objExportExcelSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExportExcelSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UpdUserId);
 var strUpdUserId = objExportExcelSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objExportExcelSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.Memo);
 var strMemo = objExportExcelSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExportExcelSet");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objExportExcelSetEN.IdExportExcel4Users;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsExportExcelSetEN objExportExcelSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcelSetEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objExportExcelSetEN.IdExportExcel4Users !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.IdExportExcel4Users);
 var strIdExportExcel4Users = objExportExcelSetEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExportExcel4Users + "'");
 }
 
 if (objExportExcelSetEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.ViewName);
 var strViewName = objExportExcelSetEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objExportExcelSetEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.TabName);
 var strTabName = objExportExcelSetEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objExportExcelSetEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UserId);
 var strUserId = objExportExcelSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conExportExcelSet.IsDefaultUser);
 arrValueListForInsert.Add("'" + (objExportExcelSetEN.IsDefaultUser  ==  false ? "0" : "1") + "'");
 
 if (objExportExcelSetEN.ExportFileName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.ExportFileName);
 var strExportFileName = objExportExcelSetEN.ExportFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportFileName + "'");
 }
 
 if (objExportExcelSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UpdDate);
 var strUpdDate = objExportExcelSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExportExcelSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.UpdUserId);
 var strUpdUserId = objExportExcelSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objExportExcelSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExportExcelSet.Memo);
 var strMemo = objExportExcelSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExportExcelSet");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewExportExcelSets(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where IdExportExcel4Users = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ExportExcelSet");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdExportExcel4Users = oRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim();
if (IsExist(strIdExportExcel4Users))
{
 string strResult = "关键字变量值为:" + string.Format("IdExportExcel4Users = {0}", strIdExportExcel4Users) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsExportExcelSetEN._CurrTabName ].NewRow();
objRow[conExportExcelSet.IdExportExcel4Users] = oRow[conExportExcelSet.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objRow[conExportExcelSet.ViewName] = oRow[conExportExcelSet.ViewName].ToString().Trim(); //界面名称
objRow[conExportExcelSet.TabName] = oRow[conExportExcelSet.TabName].ToString().Trim(); //表名
objRow[conExportExcelSet.UserId] = oRow[conExportExcelSet.UserId].ToString().Trim(); //用户Id
objRow[conExportExcelSet.IsDefaultUser] = oRow[conExportExcelSet.IsDefaultUser].ToString().Trim(); //是否缺省用户
objRow[conExportExcelSet.ExportFileName] = oRow[conExportExcelSet.ExportFileName].ToString().Trim(); //导出文件名
objRow[conExportExcelSet.UpdDate] = oRow[conExportExcelSet.UpdDate].ToString().Trim(); //修改日期
objRow[conExportExcelSet.UpdUserId] = oRow[conExportExcelSet.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conExportExcelSet.Memo] = oRow[conExportExcelSet.Memo].ToString().Trim(); //说明
 objDS.Tables[clsExportExcelSetEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsExportExcelSetEN._CurrTabName);
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
 /// <param name = "objExportExcelSetEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsExportExcelSetEN objExportExcelSetEN)
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcelSetEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcelSet where IdExportExcel4Users = " + "'"+ objExportExcelSetEN.IdExportExcel4Users+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsExportExcelSetEN._CurrTabName);
if (objDS.Tables[clsExportExcelSetEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdExportExcel4Users = " + "'"+ objExportExcelSetEN.IdExportExcel4Users+"'");
return false;
}
objRow = objDS.Tables[clsExportExcelSetEN._CurrTabName].Rows[0];
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.IdExportExcel4Users))
 {
objRow[conExportExcelSet.IdExportExcel4Users] = objExportExcelSetEN.IdExportExcel4Users; //导出Excel用户字段流水号
 }
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ViewName))
 {
objRow[conExportExcelSet.ViewName] = objExportExcelSetEN.ViewName; //界面名称
 }
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.TabName))
 {
objRow[conExportExcelSet.TabName] = objExportExcelSetEN.TabName; //表名
 }
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UserId))
 {
objRow[conExportExcelSet.UserId] = objExportExcelSetEN.UserId; //用户Id
 }
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.IsDefaultUser))
 {
objRow[conExportExcelSet.IsDefaultUser] = objExportExcelSetEN.IsDefaultUser; //是否缺省用户
 }
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ExportFileName))
 {
objRow[conExportExcelSet.ExportFileName] = objExportExcelSetEN.ExportFileName; //导出文件名
 }
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdDate))
 {
objRow[conExportExcelSet.UpdDate] = objExportExcelSetEN.UpdDate; //修改日期
 }
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdUserId))
 {
objRow[conExportExcelSet.UpdUserId] = objExportExcelSetEN.UpdUserId; //修改用户Id
 }
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.Memo))
 {
objRow[conExportExcelSet.Memo] = objExportExcelSetEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsExportExcelSetEN._CurrTabName);
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
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsExportExcelSetEN objExportExcelSetEN)
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcelSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ExportExcelSet Set ");
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ViewName))
 {
 if (objExportExcelSetEN.ViewName !=  null)
 {
 var strViewName = objExportExcelSetEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conExportExcelSet.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.ViewName); //界面名称
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.TabName))
 {
 if (objExportExcelSetEN.TabName !=  null)
 {
 var strTabName = objExportExcelSetEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conExportExcelSet.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.TabName); //表名
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UserId))
 {
 if (objExportExcelSetEN.UserId !=  null)
 {
 var strUserId = objExportExcelSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conExportExcelSet.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.UserId); //用户Id
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.IsDefaultUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExportExcelSetEN.IsDefaultUser == true?"1":"0", conExportExcelSet.IsDefaultUser); //是否缺省用户
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ExportFileName))
 {
 if (objExportExcelSetEN.ExportFileName !=  null)
 {
 var strExportFileName = objExportExcelSetEN.ExportFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExportFileName, conExportExcelSet.ExportFileName); //导出文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.ExportFileName); //导出文件名
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdDate))
 {
 if (objExportExcelSetEN.UpdDate !=  null)
 {
 var strUpdDate = objExportExcelSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conExportExcelSet.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.UpdDate); //修改日期
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdUserId))
 {
 if (objExportExcelSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objExportExcelSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conExportExcelSet.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.UpdUserId); //修改用户Id
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.Memo))
 {
 if (objExportExcelSetEN.Memo !=  null)
 {
 var strMemo = objExportExcelSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conExportExcelSet.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdExportExcel4Users = '{0}'", objExportExcelSetEN.IdExportExcel4Users); 
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
 /// <param name = "objExportExcelSetEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsExportExcelSetEN objExportExcelSetEN, string strCondition)
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcelSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExportExcelSet Set ");
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ViewName))
 {
 if (objExportExcelSetEN.ViewName !=  null)
 {
 var strViewName = objExportExcelSetEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.TabName))
 {
 if (objExportExcelSetEN.TabName !=  null)
 {
 var strTabName = objExportExcelSetEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UserId))
 {
 if (objExportExcelSetEN.UserId !=  null)
 {
 var strUserId = objExportExcelSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.IsDefaultUser))
 {
 sbSQL.AppendFormat(" IsDefaultUser = '{0}',", objExportExcelSetEN.IsDefaultUser == true?"1":"0"); //是否缺省用户
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ExportFileName))
 {
 if (objExportExcelSetEN.ExportFileName !=  null)
 {
 var strExportFileName = objExportExcelSetEN.ExportFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExportFileName = '{0}',", strExportFileName); //导出文件名
 }
 else
 {
 sbSQL.Append(" ExportFileName = null,"); //导出文件名
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdDate))
 {
 if (objExportExcelSetEN.UpdDate !=  null)
 {
 var strUpdDate = objExportExcelSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdUserId))
 {
 if (objExportExcelSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objExportExcelSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.Memo))
 {
 if (objExportExcelSetEN.Memo !=  null)
 {
 var strMemo = objExportExcelSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objExportExcelSetEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsExportExcelSetEN objExportExcelSetEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcelSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExportExcelSet Set ");
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ViewName))
 {
 if (objExportExcelSetEN.ViewName !=  null)
 {
 var strViewName = objExportExcelSetEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.TabName))
 {
 if (objExportExcelSetEN.TabName !=  null)
 {
 var strTabName = objExportExcelSetEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UserId))
 {
 if (objExportExcelSetEN.UserId !=  null)
 {
 var strUserId = objExportExcelSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.IsDefaultUser))
 {
 sbSQL.AppendFormat(" IsDefaultUser = '{0}',", objExportExcelSetEN.IsDefaultUser == true?"1":"0"); //是否缺省用户
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ExportFileName))
 {
 if (objExportExcelSetEN.ExportFileName !=  null)
 {
 var strExportFileName = objExportExcelSetEN.ExportFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExportFileName = '{0}',", strExportFileName); //导出文件名
 }
 else
 {
 sbSQL.Append(" ExportFileName = null,"); //导出文件名
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdDate))
 {
 if (objExportExcelSetEN.UpdDate !=  null)
 {
 var strUpdDate = objExportExcelSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdUserId))
 {
 if (objExportExcelSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objExportExcelSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.Memo))
 {
 if (objExportExcelSetEN.Memo !=  null)
 {
 var strMemo = objExportExcelSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objExportExcelSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsExportExcelSetEN objExportExcelSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objExportExcelSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcelSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcelSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExportExcelSet Set ");
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ViewName))
 {
 if (objExportExcelSetEN.ViewName !=  null)
 {
 var strViewName = objExportExcelSetEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conExportExcelSet.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.ViewName); //界面名称
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.TabName))
 {
 if (objExportExcelSetEN.TabName !=  null)
 {
 var strTabName = objExportExcelSetEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conExportExcelSet.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.TabName); //表名
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UserId))
 {
 if (objExportExcelSetEN.UserId !=  null)
 {
 var strUserId = objExportExcelSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conExportExcelSet.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.UserId); //用户Id
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.IsDefaultUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExportExcelSetEN.IsDefaultUser == true?"1":"0", conExportExcelSet.IsDefaultUser); //是否缺省用户
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.ExportFileName))
 {
 if (objExportExcelSetEN.ExportFileName !=  null)
 {
 var strExportFileName = objExportExcelSetEN.ExportFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExportFileName, conExportExcelSet.ExportFileName); //导出文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.ExportFileName); //导出文件名
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdDate))
 {
 if (objExportExcelSetEN.UpdDate !=  null)
 {
 var strUpdDate = objExportExcelSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conExportExcelSet.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.UpdDate); //修改日期
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.UpdUserId))
 {
 if (objExportExcelSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objExportExcelSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conExportExcelSet.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.UpdUserId); //修改用户Id
 }
 }
 
 if (objExportExcelSetEN.IsUpdated(conExportExcelSet.Memo))
 {
 if (objExportExcelSetEN.Memo !=  null)
 {
 var strMemo = objExportExcelSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conExportExcelSet.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcelSet.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdExportExcel4Users = '{0}'", objExportExcelSetEN.IdExportExcel4Users); 
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
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdExportExcel4Users) 
{
CheckPrimaryKey(strIdExportExcel4Users);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdExportExcel4Users,
};
 objSQL.ExecSP("ExportExcelSet_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdExportExcel4Users, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdExportExcel4Users);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
//删除ExportExcelSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExportExcelSet where IdExportExcel4Users = " + "'"+ strIdExportExcel4Users+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelExportExcelSet(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除ExportExcelSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExportExcelSet where IdExportExcel4Users in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdExportExcel4Users">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdExportExcel4Users) 
{
CheckPrimaryKey(strIdExportExcel4Users);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
//删除ExportExcelSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExportExcelSet where IdExportExcel4Users = " + "'"+ strIdExportExcel4Users+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelExportExcelSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsExportExcelSetDA: DelExportExcelSet)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ExportExcelSet where " + strCondition ;
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
public bool DelExportExcelSetWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsExportExcelSetDA: DelExportExcelSetWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ExportExcelSet where " + strCondition ;
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
 /// <param name = "objExportExcelSetENS">源对象</param>
 /// <param name = "objExportExcelSetENT">目标对象</param>
public void CopyTo(clsExportExcelSetEN objExportExcelSetENS, clsExportExcelSetEN objExportExcelSetENT)
{
objExportExcelSetENT.IdExportExcel4Users = objExportExcelSetENS.IdExportExcel4Users; //导出Excel用户字段流水号
objExportExcelSetENT.ViewName = objExportExcelSetENS.ViewName; //界面名称
objExportExcelSetENT.TabName = objExportExcelSetENS.TabName; //表名
objExportExcelSetENT.UserId = objExportExcelSetENS.UserId; //用户Id
objExportExcelSetENT.IsDefaultUser = objExportExcelSetENS.IsDefaultUser; //是否缺省用户
objExportExcelSetENT.ExportFileName = objExportExcelSetENS.ExportFileName; //导出文件名
objExportExcelSetENT.UpdDate = objExportExcelSetENS.UpdDate; //修改日期
objExportExcelSetENT.UpdUserId = objExportExcelSetENS.UpdUserId; //修改用户Id
objExportExcelSetENT.Memo = objExportExcelSetENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsExportExcelSetEN objExportExcelSetEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objExportExcelSetEN.ViewName, conExportExcelSet.ViewName);
clsCheckSql.CheckFieldNotNull(objExportExcelSetEN.TabName, conExportExcelSet.TabName);
clsCheckSql.CheckFieldNotNull(objExportExcelSetEN.UserId, conExportExcelSet.UserId);
clsCheckSql.CheckFieldNotNull(objExportExcelSetEN.IsDefaultUser, conExportExcelSet.IsDefaultUser);
clsCheckSql.CheckFieldNotNull(objExportExcelSetEN.ExportFileName, conExportExcelSet.ExportFileName);
clsCheckSql.CheckFieldNotNull(objExportExcelSetEN.UpdDate, conExportExcelSet.UpdDate);
clsCheckSql.CheckFieldNotNull(objExportExcelSetEN.UpdUserId, conExportExcelSet.UpdUserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objExportExcelSetEN.IdExportExcel4Users, 8, conExportExcelSet.IdExportExcel4Users);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.ViewName, 100, conExportExcelSet.ViewName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.TabName, 100, conExportExcelSet.TabName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UserId, 18, conExportExcelSet.UserId);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.ExportFileName, 100, conExportExcelSet.ExportFileName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UpdDate, 20, conExportExcelSet.UpdDate);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UpdUserId, 20, conExportExcelSet.UpdUserId);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.Memo, 1000, conExportExcelSet.Memo);
//检查字段外键固定长度
 objExportExcelSetEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsExportExcelSetEN objExportExcelSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objExportExcelSetEN.ViewName, 100, conExportExcelSet.ViewName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.TabName, 100, conExportExcelSet.TabName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UserId, 18, conExportExcelSet.UserId);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.ExportFileName, 100, conExportExcelSet.ExportFileName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UpdDate, 20, conExportExcelSet.UpdDate);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UpdUserId, 20, conExportExcelSet.UpdUserId);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.Memo, 1000, conExportExcelSet.Memo);
//检查外键字段长度
 objExportExcelSetEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsExportExcelSetEN objExportExcelSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objExportExcelSetEN.IdExportExcel4Users, 8, conExportExcelSet.IdExportExcel4Users);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.ViewName, 100, conExportExcelSet.ViewName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.TabName, 100, conExportExcelSet.TabName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UserId, 18, conExportExcelSet.UserId);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.ExportFileName, 100, conExportExcelSet.ExportFileName);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UpdDate, 20, conExportExcelSet.UpdDate);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.UpdUserId, 20, conExportExcelSet.UpdUserId);
clsCheckSql.CheckFieldLen(objExportExcelSetEN.Memo, 1000, conExportExcelSet.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objExportExcelSetEN.IdExportExcel4Users, conExportExcelSet.IdExportExcel4Users);
clsCheckSql.CheckSqlInjection4Field(objExportExcelSetEN.ViewName, conExportExcelSet.ViewName);
clsCheckSql.CheckSqlInjection4Field(objExportExcelSetEN.TabName, conExportExcelSet.TabName);
clsCheckSql.CheckSqlInjection4Field(objExportExcelSetEN.UserId, conExportExcelSet.UserId);
clsCheckSql.CheckSqlInjection4Field(objExportExcelSetEN.ExportFileName, conExportExcelSet.ExportFileName);
clsCheckSql.CheckSqlInjection4Field(objExportExcelSetEN.UpdDate, conExportExcelSet.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objExportExcelSetEN.UpdUserId, conExportExcelSet.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objExportExcelSetEN.Memo, conExportExcelSet.Memo);
//检查外键字段长度
 objExportExcelSetEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ExportExcelSet(导出Excel设置),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objExportExcelSetEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsExportExcelSetEN objExportExcelSetEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ViewName = '{0}'", objExportExcelSetEN.ViewName);
 sbCondition.AppendFormat(" and UserId = '{0}'", objExportExcelSetEN.UserId);
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsExportExcelSetEN._CurrTabName);
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsExportExcelSetEN._CurrTabName, strCondition);
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
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
 objSQL = clsExportExcelSetDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}