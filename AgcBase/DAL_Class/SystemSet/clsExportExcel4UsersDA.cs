
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcel4UsersDA
 表名:ExportExcel4Users(00050241)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:20
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
 /// 导出Excel用户字段(ExportExcel4Users)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsExportExcel4UsersDA : clsCommBase4DA
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
 return clsExportExcel4UsersEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsExportExcel4UsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsExportExcel4UsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsExportExcel4UsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsExportExcel4UsersEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ExportExcel4Users(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTable_ExportExcel4Users)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExportExcel4Users where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExportExcel4Users where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ExportExcel4Users where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ExportExcel4Users.* " + 
$"from ExportExcel4Users " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ExportExcel4Users.mId not in " + 
$"(Select top {intTop_In} ExportExcel4Users.mId from ExportExcel4Users " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExportExcel4Users where {1} and mId not in (Select top {2} mId from ExportExcel4Users where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExportExcel4Users where {1} and mId not in (Select top {3} mId from ExportExcel4Users where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ExportExcel4Users.* " + 
$"from ExportExcel4Users " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ExportExcel4Users.mId not in " + 
$"(Select top {intTop_In} ExportExcel4Users.mId from ExportExcel4Users " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ExportExcel4Users where {1} and mId not in (Select top {2} mId from ExportExcel4Users where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ExportExcel4Users where {1} and mId not in (Select top {3} mId from ExportExcel4Users where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsExportExcel4UsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA:GetObjLst)", objException.Message));
}
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = TransNullToInt(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = TransNullToBool(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = TransNullToInt(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsExportExcel4UsersDA: GetObjLst)", objException.Message));
}
objExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objExportExcel4UsersEN);
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
public List<clsExportExcel4UsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsExportExcel4UsersEN> arrObjLst = new List<clsExportExcel4UsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = TransNullToInt(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = TransNullToBool(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = TransNullToInt(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsExportExcel4UsersDA: GetObjLst)", objException.Message));
}
objExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objExportExcel4UsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetExportExcel4Users(ref clsExportExcel4UsersEN objExportExcel4UsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where mId = " + ""+ objExportExcel4UsersEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objExportExcel4UsersEN.mId = TransNullToInt(objDT.Rows[0][conExportExcel4Users.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objExportExcel4UsersEN.IdExportExcel4Users = objDT.Rows[0][conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号(字段类型:char,字段长度:8,是否可空:True)
 objExportExcel4UsersEN.FieldName = objDT.Rows[0][conExportExcel4Users.FieldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objExportExcel4UsersEN.FieldCnName = objDT.Rows[0][conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称(字段类型:varchar,字段长度:50,是否可空:False)
 objExportExcel4UsersEN.IsExport = TransNullToBool(objDT.Rows[0][conExportExcel4Users.IsExport].ToString().Trim()); //是否导出(字段类型:bit,字段长度:1,是否可空:False)
 objExportExcel4UsersEN.OrderNum = TransNullToInt(objDT.Rows[0][conExportExcel4Users.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objExportExcel4UsersEN.ViewName = objDT.Rows[0][conExportExcel4Users.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objExportExcel4UsersEN.UpdDate = objDT.Rows[0][conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objExportExcel4UsersEN.UpdUserId = objDT.Rows[0][conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objExportExcel4UsersEN.Memo = objDT.Rows[0][conExportExcel4Users.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsExportExcel4UsersDA: GetExportExcel4Users)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsExportExcel4UsersEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
 objExportExcel4UsersEN.mId = Int32.Parse(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号(字段类型:char,字段长度:8,是否可空:True)
 objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称(字段类型:varchar,字段长度:50,是否可空:False)
 objExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出(字段类型:bit,字段长度:1,是否可空:False)
 objExportExcel4UsersEN.OrderNum = Int32.Parse(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsExportExcel4UsersDA: GetObjBymId)", objException.Message));
}
return objExportExcel4UsersEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsExportExcel4UsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN()
{
mId = TransNullToInt(objRow[conExportExcel4Users.mId].ToString().Trim()), //mId
IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(), //导出Excel用户字段流水号
FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(), //字段名
FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(), //字段中文名称
IsExport = TransNullToBool(objRow[conExportExcel4Users.IsExport].ToString().Trim()), //是否导出
OrderNum = TransNullToInt(objRow[conExportExcel4Users.OrderNum].ToString().Trim()), //序号
ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(), //界面名称
UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim() //说明
};
objExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExportExcel4UsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsExportExcel4UsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsExportExcel4UsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = TransNullToInt(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = TransNullToBool(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = TransNullToInt(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsExportExcel4UsersDA: GetObjByDataRowExportExcel4Users)", objException.Message));
}
objExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExportExcel4UsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsExportExcel4UsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsExportExcel4UsersEN objExportExcel4UsersEN = new clsExportExcel4UsersEN();
try
{
objExportExcel4UsersEN.mId = TransNullToInt(objRow[conExportExcel4Users.mId].ToString().Trim()); //mId
objExportExcel4UsersEN.IdExportExcel4Users = objRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objExportExcel4UsersEN.FieldName = objRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objExportExcel4UsersEN.FieldCnName = objRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objExportExcel4UsersEN.IsExport = TransNullToBool(objRow[conExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objExportExcel4UsersEN.OrderNum = TransNullToInt(objRow[conExportExcel4Users.OrderNum].ToString().Trim()); //序号
objExportExcel4UsersEN.ViewName = objRow[conExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objExportExcel4UsersEN.UpdDate = objRow[conExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objExportExcel4UsersEN.UpdUserId = objRow[conExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objExportExcel4UsersEN.Memo = objRow[conExportExcel4Users.Memo] == DBNull.Value ? null : objRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsExportExcel4UsersDA: GetObjByDataRow)", objException.Message));
}
objExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objExportExcel4UsersEN;
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
objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsExportExcel4UsersEN._CurrTabName, conExportExcel4Users.mId, 8, "");
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
objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsExportExcel4UsersEN._CurrTabName, conExportExcel4Users.mId, 8, strPrefix);
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ExportExcel4Users where " + strCondition;
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ExportExcel4Users where " + strCondition;
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ExportExcel4Users", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ExportExcel4Users", strCondition))
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
objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ExportExcel4Users");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsExportExcel4UsersEN objExportExcel4UsersEN)
 {
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcel4UsersEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ExportExcel4Users");
objRow = objDS.Tables["ExportExcel4Users"].NewRow();
objRow[conExportExcel4Users.IdExportExcel4Users] = objExportExcel4UsersEN.IdExportExcel4Users; //导出Excel用户字段流水号
objRow[conExportExcel4Users.FieldName] = objExportExcel4UsersEN.FieldName; //字段名
objRow[conExportExcel4Users.FieldCnName] = objExportExcel4UsersEN.FieldCnName; //字段中文名称
objRow[conExportExcel4Users.IsExport] = objExportExcel4UsersEN.IsExport; //是否导出
objRow[conExportExcel4Users.OrderNum] = objExportExcel4UsersEN.OrderNum; //序号
 if (objExportExcel4UsersEN.ViewName !=  "")
 {
objRow[conExportExcel4Users.ViewName] = objExportExcel4UsersEN.ViewName; //界面名称
 }
 if (objExportExcel4UsersEN.UpdDate !=  "")
 {
objRow[conExportExcel4Users.UpdDate] = objExportExcel4UsersEN.UpdDate; //修改日期
 }
 if (objExportExcel4UsersEN.UpdUserId !=  "")
 {
objRow[conExportExcel4Users.UpdUserId] = objExportExcel4UsersEN.UpdUserId; //修改用户Id
 }
 if (objExportExcel4UsersEN.Memo !=  "")
 {
objRow[conExportExcel4Users.Memo] = objExportExcel4UsersEN.Memo; //说明
 }
objDS.Tables[clsExportExcel4UsersEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsExportExcel4UsersEN._CurrTabName);
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcel4UsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objExportExcel4UsersEN.IdExportExcel4Users !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.IdExportExcel4Users);
 var strIdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExportExcel4Users + "'");
 }
 
 if (objExportExcel4UsersEN.FieldName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.FieldName);
 var strFieldName = objExportExcel4UsersEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldName + "'");
 }
 
 if (objExportExcel4UsersEN.FieldCnName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.FieldCnName);
 var strFieldCnName = objExportExcel4UsersEN.FieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldCnName + "'");
 }
 
 arrFieldListForInsert.Add(conExportExcel4Users.IsExport);
 arrValueListForInsert.Add("'" + (objExportExcel4UsersEN.IsExport  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conExportExcel4Users.OrderNum);
 arrValueListForInsert.Add(objExportExcel4UsersEN.OrderNum.ToString());
 
 if (objExportExcel4UsersEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.ViewName);
 var strViewName = objExportExcel4UsersEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objExportExcel4UsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.UpdDate);
 var strUpdDate = objExportExcel4UsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExportExcel4UsersEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.UpdUserId);
 var strUpdUserId = objExportExcel4UsersEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objExportExcel4UsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.Memo);
 var strMemo = objExportExcel4UsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExportExcel4Users");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcel4UsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objExportExcel4UsersEN.IdExportExcel4Users !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.IdExportExcel4Users);
 var strIdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExportExcel4Users + "'");
 }
 
 if (objExportExcel4UsersEN.FieldName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.FieldName);
 var strFieldName = objExportExcel4UsersEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldName + "'");
 }
 
 if (objExportExcel4UsersEN.FieldCnName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.FieldCnName);
 var strFieldCnName = objExportExcel4UsersEN.FieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldCnName + "'");
 }
 
 arrFieldListForInsert.Add(conExportExcel4Users.IsExport);
 arrValueListForInsert.Add("'" + (objExportExcel4UsersEN.IsExport  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conExportExcel4Users.OrderNum);
 arrValueListForInsert.Add(objExportExcel4UsersEN.OrderNum.ToString());
 
 if (objExportExcel4UsersEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.ViewName);
 var strViewName = objExportExcel4UsersEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objExportExcel4UsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.UpdDate);
 var strUpdDate = objExportExcel4UsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExportExcel4UsersEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.UpdUserId);
 var strUpdUserId = objExportExcel4UsersEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objExportExcel4UsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.Memo);
 var strMemo = objExportExcel4UsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExportExcel4Users");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsExportExcel4UsersEN objExportExcel4UsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcel4UsersEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objExportExcel4UsersEN.IdExportExcel4Users !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.IdExportExcel4Users);
 var strIdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExportExcel4Users + "'");
 }
 
 if (objExportExcel4UsersEN.FieldName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.FieldName);
 var strFieldName = objExportExcel4UsersEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldName + "'");
 }
 
 if (objExportExcel4UsersEN.FieldCnName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.FieldCnName);
 var strFieldCnName = objExportExcel4UsersEN.FieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldCnName + "'");
 }
 
 arrFieldListForInsert.Add(conExportExcel4Users.IsExport);
 arrValueListForInsert.Add("'" + (objExportExcel4UsersEN.IsExport  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conExportExcel4Users.OrderNum);
 arrValueListForInsert.Add(objExportExcel4UsersEN.OrderNum.ToString());
 
 if (objExportExcel4UsersEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.ViewName);
 var strViewName = objExportExcel4UsersEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objExportExcel4UsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.UpdDate);
 var strUpdDate = objExportExcel4UsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExportExcel4UsersEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.UpdUserId);
 var strUpdUserId = objExportExcel4UsersEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objExportExcel4UsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.Memo);
 var strMemo = objExportExcel4UsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExportExcel4Users");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsExportExcel4UsersEN objExportExcel4UsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objExportExcel4UsersEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objExportExcel4UsersEN.IdExportExcel4Users !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.IdExportExcel4Users);
 var strIdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExportExcel4Users + "'");
 }
 
 if (objExportExcel4UsersEN.FieldName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.FieldName);
 var strFieldName = objExportExcel4UsersEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldName + "'");
 }
 
 if (objExportExcel4UsersEN.FieldCnName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.FieldCnName);
 var strFieldCnName = objExportExcel4UsersEN.FieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldCnName + "'");
 }
 
 arrFieldListForInsert.Add(conExportExcel4Users.IsExport);
 arrValueListForInsert.Add("'" + (objExportExcel4UsersEN.IsExport  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conExportExcel4Users.OrderNum);
 arrValueListForInsert.Add(objExportExcel4UsersEN.OrderNum.ToString());
 
 if (objExportExcel4UsersEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.ViewName);
 var strViewName = objExportExcel4UsersEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 if (objExportExcel4UsersEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.UpdDate);
 var strUpdDate = objExportExcel4UsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objExportExcel4UsersEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.UpdUserId);
 var strUpdUserId = objExportExcel4UsersEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objExportExcel4UsersEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conExportExcel4Users.Memo);
 var strMemo = objExportExcel4UsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ExportExcel4Users");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewExportExcel4Userss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ExportExcel4Users");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conExportExcel4Users.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsExportExcel4UsersEN._CurrTabName ].NewRow();
objRow[conExportExcel4Users.IdExportExcel4Users] = oRow[conExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objRow[conExportExcel4Users.FieldName] = oRow[conExportExcel4Users.FieldName].ToString().Trim(); //字段名
objRow[conExportExcel4Users.FieldCnName] = oRow[conExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objRow[conExportExcel4Users.IsExport] = oRow[conExportExcel4Users.IsExport].ToString().Trim(); //是否导出
objRow[conExportExcel4Users.OrderNum] = oRow[conExportExcel4Users.OrderNum].ToString().Trim(); //序号
objRow[conExportExcel4Users.ViewName] = oRow[conExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objRow[conExportExcel4Users.UpdDate] = oRow[conExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objRow[conExportExcel4Users.UpdUserId] = oRow[conExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conExportExcel4Users.Memo] = oRow[conExportExcel4Users.Memo].ToString().Trim(); //说明
 objDS.Tables[clsExportExcel4UsersEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsExportExcel4UsersEN._CurrTabName);
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
 /// <param name = "objExportExcel4UsersEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcel4UsersEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from ExportExcel4Users where mId = " + ""+ objExportExcel4UsersEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsExportExcel4UsersEN._CurrTabName);
if (objDS.Tables[clsExportExcel4UsersEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objExportExcel4UsersEN.mId+"");
return false;
}
objRow = objDS.Tables[clsExportExcel4UsersEN._CurrTabName].Rows[0];
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IdExportExcel4Users))
 {
objRow[conExportExcel4Users.IdExportExcel4Users] = objExportExcel4UsersEN.IdExportExcel4Users; //导出Excel用户字段流水号
 }
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldName))
 {
objRow[conExportExcel4Users.FieldName] = objExportExcel4UsersEN.FieldName; //字段名
 }
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldCnName))
 {
objRow[conExportExcel4Users.FieldCnName] = objExportExcel4UsersEN.FieldCnName; //字段中文名称
 }
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IsExport))
 {
objRow[conExportExcel4Users.IsExport] = objExportExcel4UsersEN.IsExport; //是否导出
 }
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.OrderNum))
 {
objRow[conExportExcel4Users.OrderNum] = objExportExcel4UsersEN.OrderNum; //序号
 }
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.ViewName))
 {
objRow[conExportExcel4Users.ViewName] = objExportExcel4UsersEN.ViewName; //界面名称
 }
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdDate))
 {
objRow[conExportExcel4Users.UpdDate] = objExportExcel4UsersEN.UpdDate; //修改日期
 }
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdUserId))
 {
objRow[conExportExcel4Users.UpdUserId] = objExportExcel4UsersEN.UpdUserId; //修改用户Id
 }
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.Memo))
 {
objRow[conExportExcel4Users.Memo] = objExportExcel4UsersEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsExportExcel4UsersEN._CurrTabName);
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcel4UsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ExportExcel4Users Set ");
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IdExportExcel4Users))
 {
 if (objExportExcel4UsersEN.IdExportExcel4Users !=  null)
 {
 var strIdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExportExcel4Users, conExportExcel4Users.IdExportExcel4Users); //导出Excel用户字段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.IdExportExcel4Users); //导出Excel用户字段流水号
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldName))
 {
 if (objExportExcel4UsersEN.FieldName !=  null)
 {
 var strFieldName = objExportExcel4UsersEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldName, conExportExcel4Users.FieldName); //字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.FieldName); //字段名
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldCnName))
 {
 if (objExportExcel4UsersEN.FieldCnName !=  null)
 {
 var strFieldCnName = objExportExcel4UsersEN.FieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldCnName, conExportExcel4Users.FieldCnName); //字段中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.FieldCnName); //字段中文名称
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IsExport))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExportExcel4UsersEN.IsExport == true?"1":"0", conExportExcel4Users.IsExport); //是否导出
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objExportExcel4UsersEN.OrderNum, conExportExcel4Users.OrderNum); //序号
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.ViewName))
 {
 if (objExportExcel4UsersEN.ViewName !=  null)
 {
 var strViewName = objExportExcel4UsersEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conExportExcel4Users.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.ViewName); //界面名称
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdDate))
 {
 if (objExportExcel4UsersEN.UpdDate !=  null)
 {
 var strUpdDate = objExportExcel4UsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conExportExcel4Users.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.UpdDate); //修改日期
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdUserId))
 {
 if (objExportExcel4UsersEN.UpdUserId !=  null)
 {
 var strUpdUserId = objExportExcel4UsersEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conExportExcel4Users.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.UpdUserId); //修改用户Id
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.Memo))
 {
 if (objExportExcel4UsersEN.Memo !=  null)
 {
 var strMemo = objExportExcel4UsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conExportExcel4Users.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objExportExcel4UsersEN.mId); 
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
 /// <param name = "objExportExcel4UsersEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsExportExcel4UsersEN objExportExcel4UsersEN, string strCondition)
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcel4UsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExportExcel4Users Set ");
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IdExportExcel4Users))
 {
 if (objExportExcel4UsersEN.IdExportExcel4Users !=  null)
 {
 var strIdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExportExcel4Users = '{0}',", strIdExportExcel4Users); //导出Excel用户字段流水号
 }
 else
 {
 sbSQL.Append(" IdExportExcel4Users = null,"); //导出Excel用户字段流水号
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldName))
 {
 if (objExportExcel4UsersEN.FieldName !=  null)
 {
 var strFieldName = objExportExcel4UsersEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldName = '{0}',", strFieldName); //字段名
 }
 else
 {
 sbSQL.Append(" FieldName = null,"); //字段名
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldCnName))
 {
 if (objExportExcel4UsersEN.FieldCnName !=  null)
 {
 var strFieldCnName = objExportExcel4UsersEN.FieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldCnName = '{0}',", strFieldCnName); //字段中文名称
 }
 else
 {
 sbSQL.Append(" FieldCnName = null,"); //字段中文名称
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IsExport))
 {
 sbSQL.AppendFormat(" IsExport = '{0}',", objExportExcel4UsersEN.IsExport == true?"1":"0"); //是否导出
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objExportExcel4UsersEN.OrderNum); //序号
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.ViewName))
 {
 if (objExportExcel4UsersEN.ViewName !=  null)
 {
 var strViewName = objExportExcel4UsersEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdDate))
 {
 if (objExportExcel4UsersEN.UpdDate !=  null)
 {
 var strUpdDate = objExportExcel4UsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdUserId))
 {
 if (objExportExcel4UsersEN.UpdUserId !=  null)
 {
 var strUpdUserId = objExportExcel4UsersEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.Memo))
 {
 if (objExportExcel4UsersEN.Memo !=  null)
 {
 var strMemo = objExportExcel4UsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objExportExcel4UsersEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsExportExcel4UsersEN objExportExcel4UsersEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcel4UsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExportExcel4Users Set ");
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IdExportExcel4Users))
 {
 if (objExportExcel4UsersEN.IdExportExcel4Users !=  null)
 {
 var strIdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExportExcel4Users = '{0}',", strIdExportExcel4Users); //导出Excel用户字段流水号
 }
 else
 {
 sbSQL.Append(" IdExportExcel4Users = null,"); //导出Excel用户字段流水号
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldName))
 {
 if (objExportExcel4UsersEN.FieldName !=  null)
 {
 var strFieldName = objExportExcel4UsersEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldName = '{0}',", strFieldName); //字段名
 }
 else
 {
 sbSQL.Append(" FieldName = null,"); //字段名
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldCnName))
 {
 if (objExportExcel4UsersEN.FieldCnName !=  null)
 {
 var strFieldCnName = objExportExcel4UsersEN.FieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldCnName = '{0}',", strFieldCnName); //字段中文名称
 }
 else
 {
 sbSQL.Append(" FieldCnName = null,"); //字段中文名称
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IsExport))
 {
 sbSQL.AppendFormat(" IsExport = '{0}',", objExportExcel4UsersEN.IsExport == true?"1":"0"); //是否导出
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objExportExcel4UsersEN.OrderNum); //序号
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.ViewName))
 {
 if (objExportExcel4UsersEN.ViewName !=  null)
 {
 var strViewName = objExportExcel4UsersEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdDate))
 {
 if (objExportExcel4UsersEN.UpdDate !=  null)
 {
 var strUpdDate = objExportExcel4UsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdUserId))
 {
 if (objExportExcel4UsersEN.UpdUserId !=  null)
 {
 var strUpdUserId = objExportExcel4UsersEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.Memo))
 {
 if (objExportExcel4UsersEN.Memo !=  null)
 {
 var strMemo = objExportExcel4UsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objExportExcel4UsersEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsExportExcel4UsersEN objExportExcel4UsersEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objExportExcel4UsersEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objExportExcel4UsersEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objExportExcel4UsersEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ExportExcel4Users Set ");
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IdExportExcel4Users))
 {
 if (objExportExcel4UsersEN.IdExportExcel4Users !=  null)
 {
 var strIdExportExcel4Users = objExportExcel4UsersEN.IdExportExcel4Users.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExportExcel4Users, conExportExcel4Users.IdExportExcel4Users); //导出Excel用户字段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.IdExportExcel4Users); //导出Excel用户字段流水号
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldName))
 {
 if (objExportExcel4UsersEN.FieldName !=  null)
 {
 var strFieldName = objExportExcel4UsersEN.FieldName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldName, conExportExcel4Users.FieldName); //字段名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.FieldName); //字段名
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.FieldCnName))
 {
 if (objExportExcel4UsersEN.FieldCnName !=  null)
 {
 var strFieldCnName = objExportExcel4UsersEN.FieldCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldCnName, conExportExcel4Users.FieldCnName); //字段中文名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.FieldCnName); //字段中文名称
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.IsExport))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objExportExcel4UsersEN.IsExport == true?"1":"0", conExportExcel4Users.IsExport); //是否导出
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objExportExcel4UsersEN.OrderNum, conExportExcel4Users.OrderNum); //序号
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.ViewName))
 {
 if (objExportExcel4UsersEN.ViewName !=  null)
 {
 var strViewName = objExportExcel4UsersEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conExportExcel4Users.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.ViewName); //界面名称
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdDate))
 {
 if (objExportExcel4UsersEN.UpdDate !=  null)
 {
 var strUpdDate = objExportExcel4UsersEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conExportExcel4Users.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.UpdDate); //修改日期
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.UpdUserId))
 {
 if (objExportExcel4UsersEN.UpdUserId !=  null)
 {
 var strUpdUserId = objExportExcel4UsersEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conExportExcel4Users.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.UpdUserId); //修改用户Id
 }
 }
 
 if (objExportExcel4UsersEN.IsUpdated(conExportExcel4Users.Memo))
 {
 if (objExportExcel4UsersEN.Memo !=  null)
 {
 var strMemo = objExportExcel4UsersEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conExportExcel4Users.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conExportExcel4Users.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objExportExcel4UsersEN.mId); 
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ExportExcel4Users_Delete", values);
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
//删除ExportExcel4Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExportExcel4Users where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelExportExcel4Users(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
//删除ExportExcel4Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExportExcel4Users where mId in (" + strKeyList + ")";
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
//删除ExportExcel4Users本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ExportExcel4Users where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelExportExcel4Users(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: DelExportExcel4Users)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ExportExcel4Users where " + strCondition ;
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
public bool DelExportExcel4UsersWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsExportExcel4UsersDA: DelExportExcel4UsersWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ExportExcel4Users where " + strCondition ;
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
 /// <param name = "objExportExcel4UsersENS">源对象</param>
 /// <param name = "objExportExcel4UsersENT">目标对象</param>
public void CopyTo(clsExportExcel4UsersEN objExportExcel4UsersENS, clsExportExcel4UsersEN objExportExcel4UsersENT)
{
objExportExcel4UsersENT.mId = objExportExcel4UsersENS.mId; //mId
objExportExcel4UsersENT.IdExportExcel4Users = objExportExcel4UsersENS.IdExportExcel4Users; //导出Excel用户字段流水号
objExportExcel4UsersENT.FieldName = objExportExcel4UsersENS.FieldName; //字段名
objExportExcel4UsersENT.FieldCnName = objExportExcel4UsersENS.FieldCnName; //字段中文名称
objExportExcel4UsersENT.IsExport = objExportExcel4UsersENS.IsExport; //是否导出
objExportExcel4UsersENT.OrderNum = objExportExcel4UsersENS.OrderNum; //序号
objExportExcel4UsersENT.ViewName = objExportExcel4UsersENS.ViewName; //界面名称
objExportExcel4UsersENT.UpdDate = objExportExcel4UsersENS.UpdDate; //修改日期
objExportExcel4UsersENT.UpdUserId = objExportExcel4UsersENS.UpdUserId; //修改用户Id
objExportExcel4UsersENT.Memo = objExportExcel4UsersENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objExportExcel4UsersEN.IdExportExcel4Users, conExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckFieldNotNull(objExportExcel4UsersEN.FieldName, conExportExcel4Users.FieldName);
clsCheckSql.CheckFieldNotNull(objExportExcel4UsersEN.FieldCnName, conExportExcel4Users.FieldCnName);
clsCheckSql.CheckFieldNotNull(objExportExcel4UsersEN.IsExport, conExportExcel4Users.IsExport);
clsCheckSql.CheckFieldNotNull(objExportExcel4UsersEN.OrderNum, conExportExcel4Users.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.IdExportExcel4Users, 8, conExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.FieldName, 50, conExportExcel4Users.FieldName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.FieldCnName, 50, conExportExcel4Users.FieldCnName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.ViewName, 100, conExportExcel4Users.ViewName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.UpdDate, 20, conExportExcel4Users.UpdDate);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.UpdUserId, 20, conExportExcel4Users.UpdUserId);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.Memo, 1000, conExportExcel4Users.Memo);
//检查字段外键固定长度
 objExportExcel4UsersEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.IdExportExcel4Users, 8, conExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.FieldName, 50, conExportExcel4Users.FieldName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.FieldCnName, 50, conExportExcel4Users.FieldCnName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.ViewName, 100, conExportExcel4Users.ViewName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.UpdDate, 20, conExportExcel4Users.UpdDate);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.UpdUserId, 20, conExportExcel4Users.UpdUserId);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.Memo, 1000, conExportExcel4Users.Memo);
//检查外键字段长度
 objExportExcel4UsersEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.IdExportExcel4Users, 8, conExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.FieldName, 50, conExportExcel4Users.FieldName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.FieldCnName, 50, conExportExcel4Users.FieldCnName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.ViewName, 100, conExportExcel4Users.ViewName);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.UpdDate, 20, conExportExcel4Users.UpdDate);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.UpdUserId, 20, conExportExcel4Users.UpdUserId);
clsCheckSql.CheckFieldLen(objExportExcel4UsersEN.Memo, 1000, conExportExcel4Users.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objExportExcel4UsersEN.IdExportExcel4Users, conExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckSqlInjection4Field(objExportExcel4UsersEN.FieldName, conExportExcel4Users.FieldName);
clsCheckSql.CheckSqlInjection4Field(objExportExcel4UsersEN.FieldCnName, conExportExcel4Users.FieldCnName);
clsCheckSql.CheckSqlInjection4Field(objExportExcel4UsersEN.ViewName, conExportExcel4Users.ViewName);
clsCheckSql.CheckSqlInjection4Field(objExportExcel4UsersEN.UpdDate, conExportExcel4Users.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objExportExcel4UsersEN.UpdUserId, conExportExcel4Users.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objExportExcel4UsersEN.Memo, conExportExcel4Users.Memo);
//检查外键字段长度
 objExportExcel4UsersEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ExportExcel4Users(导出Excel用户字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objExportExcel4UsersEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsExportExcel4UsersEN objExportExcel4UsersEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdExportExcel4Users = '{0}'", objExportExcel4UsersEN.IdExportExcel4Users);
 sbCondition.AppendFormat(" and FieldName = '{0}'", objExportExcel4UsersEN.FieldName);
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsExportExcel4UsersEN._CurrTabName);
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsExportExcel4UsersEN._CurrTabName, strCondition);
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
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
 objSQL = clsExportExcel4UsersDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}