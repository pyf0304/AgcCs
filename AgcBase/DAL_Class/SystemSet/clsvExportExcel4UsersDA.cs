
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcel4UsersDA
 表名:vExportExcel4Users(00050239)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:37:14
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
 /// v导出Excel用户字段(vExportExcel4Users)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvExportExcel4UsersDA : clsCommBase4DA
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
 return clsvExportExcel4UsersEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvExportExcel4UsersEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvExportExcel4UsersEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvExportExcel4UsersEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvExportExcel4UsersEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcel4Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vExportExcel4Users(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTable_vExportExcel4Users)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcel4Users where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcel4Users where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExportExcel4Users where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExportExcel4Users where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vExportExcel4Users where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vExportExcel4Users.* " + 
$"from vExportExcel4Users " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vExportExcel4Users.mId not in " + 
$"(Select top {intTop_In} vExportExcel4Users.mId from vExportExcel4Users " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExportExcel4Users where {1} and mId not in (Select top {2} mId from vExportExcel4Users where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExportExcel4Users where {1} and mId not in (Select top {3} mId from vExportExcel4Users where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vExportExcel4Users.* " + 
$"from vExportExcel4Users " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vExportExcel4Users.mId not in " + 
$"(Select top {intTop_In} vExportExcel4Users.mId from vExportExcel4Users " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vExportExcel4Users where {1} and mId not in (Select top {2} mId from vExportExcel4Users where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vExportExcel4Users where {1} and mId not in (Select top {3} mId from vExportExcel4Users where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvExportExcel4UsersEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA:GetObjLst)", objException.Message));
}
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcel4Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = TransNullToInt(objRow[convExportExcel4Users.mId].ToString().Trim()); //mId
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //表名
objvExportExcel4UsersEN.IsDefaultUser = TransNullToBool(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户Id
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = TransNullToBool(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvExportExcel4UsersDA: GetObjLst)", objException.Message));
}
objvExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvExportExcel4UsersEN);
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
public List<clsvExportExcel4UsersEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA:GetObjLstByTabName)", objException.Message));
}
List<clsvExportExcel4UsersEN> arrObjLst = new List<clsvExportExcel4UsersEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = TransNullToInt(objRow[convExportExcel4Users.mId].ToString().Trim()); //mId
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //表名
objvExportExcel4UsersEN.IsDefaultUser = TransNullToBool(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户Id
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = TransNullToBool(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvExportExcel4UsersDA: GetObjLst)", objException.Message));
}
objvExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvExportExcel4UsersEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvExportExcel4Users(ref clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcel4Users where mId = " + ""+ objvExportExcel4UsersEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvExportExcel4UsersEN.mId = TransNullToInt(objDT.Rows[0][convExportExcel4Users.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvExportExcel4UsersEN.IdExportExcel4Users = objDT.Rows[0][convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号(字段类型:char,字段长度:8,是否可空:True)
 objvExportExcel4UsersEN.ViewName = objDT.Rows[0][convExportExcel4Users.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcel4UsersEN.TabName = objDT.Rows[0][convExportExcel4Users.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcel4UsersEN.IsDefaultUser = TransNullToBool(objDT.Rows[0][convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户(字段类型:bit,字段长度:1,是否可空:False)
 objvExportExcel4UsersEN.UserId = objDT.Rows[0][convExportExcel4Users.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvExportExcel4UsersEN.UserName = objDT.Rows[0][convExportExcel4Users.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvExportExcel4UsersEN.ExportFileName = objDT.Rows[0][convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcel4UsersEN.FieldName = objDT.Rows[0][convExportExcel4Users.FieldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvExportExcel4UsersEN.FieldCnName = objDT.Rows[0][convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvExportExcel4UsersEN.IsExport = TransNullToBool(objDT.Rows[0][convExportExcel4Users.IsExport].ToString().Trim()); //是否导出(字段类型:bit,字段长度:1,是否可空:False)
 objvExportExcel4UsersEN.OrderNum = TransNullToInt(objDT.Rows[0][convExportExcel4Users.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvExportExcel4UsersEN.UpdDate = objDT.Rows[0][convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvExportExcel4UsersEN.UpdUserId = objDT.Rows[0][convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvExportExcel4UsersEN.Memo = objDT.Rows[0][convExportExcel4Users.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvExportExcel4UsersDA: GetvExportExcel4Users)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvExportExcel4UsersEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcel4Users where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
 objvExportExcel4UsersEN.mId = Int32.Parse(objRow[convExportExcel4Users.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号(字段类型:char,字段长度:8,是否可空:True)
 objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcel4UsersEN.IsDefaultUser = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户(字段类型:bit,字段长度:1,是否可空:False)
 objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名(字段类型:varchar,字段长度:100,是否可空:False)
 objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvExportExcel4UsersEN.IsExport = clsEntityBase2.TransNullToBool_S(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出(字段类型:bit,字段长度:1,是否可空:False)
 objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvExportExcel4UsersDA: GetObjBymId)", objException.Message));
}
return objvExportExcel4UsersEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvExportExcel4UsersEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
strSQL = "Select * from vExportExcel4Users where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN()
{
mId = TransNullToInt(objRow[convExportExcel4Users.mId].ToString().Trim()), //mId
IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(), //导出Excel用户字段流水号
ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(), //界面名称
TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(), //表名
IsDefaultUser = TransNullToBool(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()), //是否缺省用户
UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(), //用户Id
UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(), //用户名
ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(), //导出文件名
FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(), //字段名
FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(), //字段中文名称
IsExport = TransNullToBool(objRow[convExportExcel4Users.IsExport].ToString().Trim()), //是否导出
OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convExportExcel4Users.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim() //说明
};
objvExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExportExcel4UsersEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvExportExcel4UsersDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvExportExcel4UsersEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = TransNullToInt(objRow[convExportExcel4Users.mId].ToString().Trim()); //mId
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //表名
objvExportExcel4UsersEN.IsDefaultUser = TransNullToBool(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户Id
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = TransNullToBool(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvExportExcel4UsersDA: GetObjByDataRowvExportExcel4Users)", objException.Message));
}
objvExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExportExcel4UsersEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvExportExcel4UsersEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvExportExcel4UsersEN objvExportExcel4UsersEN = new clsvExportExcel4UsersEN();
try
{
objvExportExcel4UsersEN.mId = TransNullToInt(objRow[convExportExcel4Users.mId].ToString().Trim()); //mId
objvExportExcel4UsersEN.IdExportExcel4Users = objRow[convExportExcel4Users.IdExportExcel4Users] == DBNull.Value ? null : objRow[convExportExcel4Users.IdExportExcel4Users].ToString().Trim(); //导出Excel用户字段流水号
objvExportExcel4UsersEN.ViewName = objRow[convExportExcel4Users.ViewName] == DBNull.Value ? null : objRow[convExportExcel4Users.ViewName].ToString().Trim(); //界面名称
objvExportExcel4UsersEN.TabName = objRow[convExportExcel4Users.TabName] == DBNull.Value ? null : objRow[convExportExcel4Users.TabName].ToString().Trim(); //表名
objvExportExcel4UsersEN.IsDefaultUser = TransNullToBool(objRow[convExportExcel4Users.IsDefaultUser].ToString().Trim()); //是否缺省用户
objvExportExcel4UsersEN.UserId = objRow[convExportExcel4Users.UserId].ToString().Trim(); //用户Id
objvExportExcel4UsersEN.UserName = objRow[convExportExcel4Users.UserName].ToString().Trim(); //用户名
objvExportExcel4UsersEN.ExportFileName = objRow[convExportExcel4Users.ExportFileName].ToString().Trim(); //导出文件名
objvExportExcel4UsersEN.FieldName = objRow[convExportExcel4Users.FieldName] == DBNull.Value ? null : objRow[convExportExcel4Users.FieldName].ToString().Trim(); //字段名
objvExportExcel4UsersEN.FieldCnName = objRow[convExportExcel4Users.FieldCnName].ToString().Trim(); //字段中文名称
objvExportExcel4UsersEN.IsExport = TransNullToBool(objRow[convExportExcel4Users.IsExport].ToString().Trim()); //是否导出
objvExportExcel4UsersEN.OrderNum = objRow[convExportExcel4Users.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convExportExcel4Users.OrderNum].ToString().Trim()); //序号
objvExportExcel4UsersEN.UpdDate = objRow[convExportExcel4Users.UpdDate] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdDate].ToString().Trim(); //修改日期
objvExportExcel4UsersEN.UpdUserId = objRow[convExportExcel4Users.UpdUserId] == DBNull.Value ? null : objRow[convExportExcel4Users.UpdUserId].ToString().Trim(); //修改用户Id
objvExportExcel4UsersEN.Memo = objRow[convExportExcel4Users.Memo] == DBNull.Value ? null : objRow[convExportExcel4Users.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvExportExcel4UsersDA: GetObjByDataRow)", objException.Message));
}
objvExportExcel4UsersEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvExportExcel4UsersEN;
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
objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvExportExcel4UsersEN._CurrTabName, convExportExcel4Users.mId, 8, "");
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
objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvExportExcel4UsersEN._CurrTabName, convExportExcel4Users.mId, 8, strPrefix);
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
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vExportExcel4Users where " + strCondition;
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
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vExportExcel4Users where " + strCondition;
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
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vExportExcel4Users", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvExportExcel4UsersDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vExportExcel4Users", strCondition))
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
objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vExportExcel4Users");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvExportExcel4UsersENS">源对象</param>
 /// <param name = "objvExportExcel4UsersENT">目标对象</param>
public void CopyTo(clsvExportExcel4UsersEN objvExportExcel4UsersENS, clsvExportExcel4UsersEN objvExportExcel4UsersENT)
{
objvExportExcel4UsersENT.mId = objvExportExcel4UsersENS.mId; //mId
objvExportExcel4UsersENT.IdExportExcel4Users = objvExportExcel4UsersENS.IdExportExcel4Users; //导出Excel用户字段流水号
objvExportExcel4UsersENT.ViewName = objvExportExcel4UsersENS.ViewName; //界面名称
objvExportExcel4UsersENT.TabName = objvExportExcel4UsersENS.TabName; //表名
objvExportExcel4UsersENT.IsDefaultUser = objvExportExcel4UsersENS.IsDefaultUser; //是否缺省用户
objvExportExcel4UsersENT.UserId = objvExportExcel4UsersENS.UserId; //用户Id
objvExportExcel4UsersENT.UserName = objvExportExcel4UsersENS.UserName; //用户名
objvExportExcel4UsersENT.ExportFileName = objvExportExcel4UsersENS.ExportFileName; //导出文件名
objvExportExcel4UsersENT.FieldName = objvExportExcel4UsersENS.FieldName; //字段名
objvExportExcel4UsersENT.FieldCnName = objvExportExcel4UsersENS.FieldCnName; //字段中文名称
objvExportExcel4UsersENT.IsExport = objvExportExcel4UsersENS.IsExport; //是否导出
objvExportExcel4UsersENT.OrderNum = objvExportExcel4UsersENS.OrderNum; //序号
objvExportExcel4UsersENT.UpdDate = objvExportExcel4UsersENS.UpdDate; //修改日期
objvExportExcel4UsersENT.UpdUserId = objvExportExcel4UsersENS.UpdUserId; //修改用户Id
objvExportExcel4UsersENT.Memo = objvExportExcel4UsersENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvExportExcel4UsersEN objvExportExcel4UsersEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.IdExportExcel4Users, 8, convExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.ViewName, 100, convExportExcel4Users.ViewName);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.TabName, 100, convExportExcel4Users.TabName);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.UserId, 18, convExportExcel4Users.UserId);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.UserName, 30, convExportExcel4Users.UserName);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.ExportFileName, 100, convExportExcel4Users.ExportFileName);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.FieldName, 50, convExportExcel4Users.FieldName);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.FieldCnName, 50, convExportExcel4Users.FieldCnName);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.UpdDate, 20, convExportExcel4Users.UpdDate);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.UpdUserId, 20, convExportExcel4Users.UpdUserId);
clsCheckSql.CheckFieldLen(objvExportExcel4UsersEN.Memo, 1000, convExportExcel4Users.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.IdExportExcel4Users, convExportExcel4Users.IdExportExcel4Users);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.ViewName, convExportExcel4Users.ViewName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.TabName, convExportExcel4Users.TabName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.UserId, convExportExcel4Users.UserId);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.UserName, convExportExcel4Users.UserName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.ExportFileName, convExportExcel4Users.ExportFileName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.FieldName, convExportExcel4Users.FieldName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.FieldCnName, convExportExcel4Users.FieldCnName);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.UpdDate, convExportExcel4Users.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.UpdUserId, convExportExcel4Users.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvExportExcel4UsersEN.Memo, convExportExcel4Users.Memo);
//检查外键字段长度
 objvExportExcel4UsersEN._IsCheckProperty = true;
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
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
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
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
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
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvExportExcel4UsersEN._CurrTabName);
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
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvExportExcel4UsersEN._CurrTabName, strCondition);
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
 objSQL = clsvExportExcel4UsersDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}