
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorIdManageDA
 表名:ErrorIdManage(00050300)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:00
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
 /// 错误Id管理(ErrorIdManage)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsErrorIdManageDA : clsCommBase4DA
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
 return clsErrorIdManageEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsErrorIdManageEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsErrorIdManageEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsErrorIdManageEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsErrorIdManageEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ErrorIdManage(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTable_ErrorIdManage)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ErrorIdManage where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ErrorIdManage where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ErrorIdManage where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ErrorIdManage.* " + 
$"from ErrorIdManage " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ErrorIdManage.mId not in " + 
$"(Select top {intTop_In} ErrorIdManage.mId from ErrorIdManage " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ErrorIdManage where {1} and mId not in (Select top {2} mId from ErrorIdManage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ErrorIdManage where {1} and mId not in (Select top {3} mId from ErrorIdManage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsErrorIdManageDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ErrorIdManage.* " + 
$"from ErrorIdManage " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ErrorIdManage.mId not in " + 
$"(Select top {intTop_In} ErrorIdManage.mId from ErrorIdManage " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ErrorIdManage where {1} and mId not in (Select top {2} mId from ErrorIdManage where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ErrorIdManage where {1} and mId not in (Select top {3} mId from ErrorIdManage where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsErrorIdManageEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsErrorIdManageDA:GetObjLst)", objException.Message));
}
List<clsErrorIdManageEN> arrObjLst = new List<clsErrorIdManageEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorIdManageEN objErrorIdManageEN = new clsErrorIdManageEN();
try
{
objErrorIdManageEN.mId = TransNullToInt(objRow[conErrorIdManage.mId].ToString().Trim()); //mId
objErrorIdManageEN.ErrID = objRow[conErrorIdManage.ErrID].ToString().Trim(); //错误Id
objErrorIdManageEN.ProgLevelTypeId = objRow[conErrorIdManage.ProgLevelTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objErrorIdManageEN.CodeTypeId = objRow[conErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objErrorIdManageEN.FunctionName = objRow[conErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objErrorIdManageEN.Explanation = objRow[conErrorIdManage.Explanation] == DBNull.Value ? null : objRow[conErrorIdManage.Explanation].ToString().Trim(); //详细说明
objErrorIdManageEN.UpdDate = objRow[conErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[conErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objErrorIdManageEN.UpdUserId = objRow[conErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[conErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objErrorIdManageEN.Memo = objRow[conErrorIdManage.Memo] == DBNull.Value ? null : objRow[conErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsErrorIdManageDA: GetObjLst)", objException.Message));
}
objErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objErrorIdManageEN);
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
public List<clsErrorIdManageEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsErrorIdManageDA:GetObjLstByTabName)", objException.Message));
}
List<clsErrorIdManageEN> arrObjLst = new List<clsErrorIdManageEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsErrorIdManageEN objErrorIdManageEN = new clsErrorIdManageEN();
try
{
objErrorIdManageEN.mId = TransNullToInt(objRow[conErrorIdManage.mId].ToString().Trim()); //mId
objErrorIdManageEN.ErrID = objRow[conErrorIdManage.ErrID].ToString().Trim(); //错误Id
objErrorIdManageEN.ProgLevelTypeId = objRow[conErrorIdManage.ProgLevelTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objErrorIdManageEN.CodeTypeId = objRow[conErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objErrorIdManageEN.FunctionName = objRow[conErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objErrorIdManageEN.Explanation = objRow[conErrorIdManage.Explanation] == DBNull.Value ? null : objRow[conErrorIdManage.Explanation].ToString().Trim(); //详细说明
objErrorIdManageEN.UpdDate = objRow[conErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[conErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objErrorIdManageEN.UpdUserId = objRow[conErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[conErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objErrorIdManageEN.Memo = objRow[conErrorIdManage.Memo] == DBNull.Value ? null : objRow[conErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsErrorIdManageDA: GetObjLst)", objException.Message));
}
objErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objErrorIdManageEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objErrorIdManageEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetErrorIdManage(ref clsErrorIdManageEN objErrorIdManageEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where mId = " + ""+ objErrorIdManageEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objErrorIdManageEN.mId = TransNullToInt(objDT.Rows[0][conErrorIdManage.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objErrorIdManageEN.ErrID = objDT.Rows[0][conErrorIdManage.ErrID].ToString().Trim(); //错误Id(字段类型:char,字段长度:10,是否可空:False)
 objErrorIdManageEN.ProgLevelTypeId = objDT.Rows[0][conErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id(字段类型:char,字段长度:2,是否可空:False)
 objErrorIdManageEN.CodeTypeId = objDT.Rows[0][conErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objErrorIdManageEN.FunctionName = objDT.Rows[0][conErrorIdManage.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objErrorIdManageEN.Explanation = objDT.Rows[0][conErrorIdManage.Explanation].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objErrorIdManageEN.UpdDate = objDT.Rows[0][conErrorIdManage.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objErrorIdManageEN.UpdUserId = objDT.Rows[0][conErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objErrorIdManageEN.Memo = objDT.Rows[0][conErrorIdManage.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsErrorIdManageDA: GetErrorIdManage)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsErrorIdManageEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsErrorIdManageEN objErrorIdManageEN = new clsErrorIdManageEN();
try
{
 objErrorIdManageEN.mId = Int32.Parse(objRow[conErrorIdManage.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objErrorIdManageEN.ErrID = objRow[conErrorIdManage.ErrID].ToString().Trim(); //错误Id(字段类型:char,字段长度:10,是否可空:False)
 objErrorIdManageEN.ProgLevelTypeId = objRow[conErrorIdManage.ProgLevelTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id(字段类型:char,字段长度:2,是否可空:False)
 objErrorIdManageEN.CodeTypeId = objRow[conErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objErrorIdManageEN.FunctionName = objRow[conErrorIdManage.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objErrorIdManageEN.Explanation = objRow[conErrorIdManage.Explanation] == DBNull.Value ? null : objRow[conErrorIdManage.Explanation].ToString().Trim(); //详细说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objErrorIdManageEN.UpdDate = objRow[conErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[conErrorIdManage.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objErrorIdManageEN.UpdUserId = objRow[conErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[conErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objErrorIdManageEN.Memo = objRow[conErrorIdManage.Memo] == DBNull.Value ? null : objRow[conErrorIdManage.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsErrorIdManageDA: GetObjBymId)", objException.Message));
}
return objErrorIdManageEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsErrorIdManageEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsErrorIdManageDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsErrorIdManageEN objErrorIdManageEN = new clsErrorIdManageEN()
{
mId = TransNullToInt(objRow[conErrorIdManage.mId].ToString().Trim()), //mId
ErrID = objRow[conErrorIdManage.ErrID].ToString().Trim(), //错误Id
ProgLevelTypeId = objRow[conErrorIdManage.ProgLevelTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.ProgLevelTypeId].ToString().Trim(), //程序分层类型Id
CodeTypeId = objRow[conErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.CodeTypeId].ToString().Trim(), //代码类型Id
FunctionName = objRow[conErrorIdManage.FunctionName].ToString().Trim(), //功能名称
Explanation = objRow[conErrorIdManage.Explanation] == DBNull.Value ? null : objRow[conErrorIdManage.Explanation].ToString().Trim(), //详细说明
UpdDate = objRow[conErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[conErrorIdManage.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[conErrorIdManage.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conErrorIdManage.Memo] == DBNull.Value ? null : objRow[conErrorIdManage.Memo].ToString().Trim() //说明
};
objErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objErrorIdManageEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsErrorIdManageDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsErrorIdManageEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsErrorIdManageEN objErrorIdManageEN = new clsErrorIdManageEN();
try
{
objErrorIdManageEN.mId = TransNullToInt(objRow[conErrorIdManage.mId].ToString().Trim()); //mId
objErrorIdManageEN.ErrID = objRow[conErrorIdManage.ErrID].ToString().Trim(); //错误Id
objErrorIdManageEN.ProgLevelTypeId = objRow[conErrorIdManage.ProgLevelTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objErrorIdManageEN.CodeTypeId = objRow[conErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objErrorIdManageEN.FunctionName = objRow[conErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objErrorIdManageEN.Explanation = objRow[conErrorIdManage.Explanation] == DBNull.Value ? null : objRow[conErrorIdManage.Explanation].ToString().Trim(); //详细说明
objErrorIdManageEN.UpdDate = objRow[conErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[conErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objErrorIdManageEN.UpdUserId = objRow[conErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[conErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objErrorIdManageEN.Memo = objRow[conErrorIdManage.Memo] == DBNull.Value ? null : objRow[conErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsErrorIdManageDA: GetObjByDataRowErrorIdManage)", objException.Message));
}
objErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objErrorIdManageEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsErrorIdManageEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsErrorIdManageEN objErrorIdManageEN = new clsErrorIdManageEN();
try
{
objErrorIdManageEN.mId = TransNullToInt(objRow[conErrorIdManage.mId].ToString().Trim()); //mId
objErrorIdManageEN.ErrID = objRow[conErrorIdManage.ErrID].ToString().Trim(); //错误Id
objErrorIdManageEN.ProgLevelTypeId = objRow[conErrorIdManage.ProgLevelTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objErrorIdManageEN.CodeTypeId = objRow[conErrorIdManage.CodeTypeId] == DBNull.Value ? null : objRow[conErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objErrorIdManageEN.FunctionName = objRow[conErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objErrorIdManageEN.Explanation = objRow[conErrorIdManage.Explanation] == DBNull.Value ? null : objRow[conErrorIdManage.Explanation].ToString().Trim(); //详细说明
objErrorIdManageEN.UpdDate = objRow[conErrorIdManage.UpdDate] == DBNull.Value ? null : objRow[conErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objErrorIdManageEN.UpdUserId = objRow[conErrorIdManage.UpdUserId] == DBNull.Value ? null : objRow[conErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objErrorIdManageEN.Memo = objRow[conErrorIdManage.Memo] == DBNull.Value ? null : objRow[conErrorIdManage.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsErrorIdManageDA: GetObjByDataRow)", objException.Message));
}
objErrorIdManageEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objErrorIdManageEN;
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
objSQL = clsErrorIdManageDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsErrorIdManageEN._CurrTabName, conErrorIdManage.mId, 8, "");
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
objSQL = clsErrorIdManageDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsErrorIdManageEN._CurrTabName, conErrorIdManage.mId, 8, strPrefix);
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ErrorIdManage where " + strCondition;
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ErrorIdManage where " + strCondition;
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ErrorIdManage", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsErrorIdManageDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ErrorIdManage", strCondition))
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
objSQL = clsErrorIdManageDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ErrorIdManage");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsErrorIdManageEN objErrorIdManageEN)
 {
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objErrorIdManageEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ErrorIdManage");
objRow = objDS.Tables["ErrorIdManage"].NewRow();
objRow[conErrorIdManage.ErrID] = objErrorIdManageEN.ErrID; //错误Id
 if (objErrorIdManageEN.ProgLevelTypeId !=  "")
 {
objRow[conErrorIdManage.ProgLevelTypeId] = objErrorIdManageEN.ProgLevelTypeId; //程序分层类型Id
 }
 if (objErrorIdManageEN.CodeTypeId !=  "")
 {
objRow[conErrorIdManage.CodeTypeId] = objErrorIdManageEN.CodeTypeId; //代码类型Id
 }
objRow[conErrorIdManage.FunctionName] = objErrorIdManageEN.FunctionName; //功能名称
 if (objErrorIdManageEN.Explanation !=  "")
 {
objRow[conErrorIdManage.Explanation] = objErrorIdManageEN.Explanation; //详细说明
 }
 if (objErrorIdManageEN.UpdDate !=  "")
 {
objRow[conErrorIdManage.UpdDate] = objErrorIdManageEN.UpdDate; //修改日期
 }
 if (objErrorIdManageEN.UpdUserId !=  "")
 {
objRow[conErrorIdManage.UpdUserId] = objErrorIdManageEN.UpdUserId; //修改用户Id
 }
 if (objErrorIdManageEN.Memo !=  "")
 {
objRow[conErrorIdManage.Memo] = objErrorIdManageEN.Memo; //说明
 }
objDS.Tables[clsErrorIdManageEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsErrorIdManageEN._CurrTabName);
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
 /// <param name = "objErrorIdManageEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsErrorIdManageEN objErrorIdManageEN)
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objErrorIdManageEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objErrorIdManageEN.ErrID !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.ErrID);
 var strErrID = objErrorIdManageEN.ErrID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrID + "'");
 }
 
 if (objErrorIdManageEN.ProgLevelTypeId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.ProgLevelTypeId);
 var strProgLevelTypeId = objErrorIdManageEN.ProgLevelTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLevelTypeId + "'");
 }
 
 if (objErrorIdManageEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.CodeTypeId);
 var strCodeTypeId = objErrorIdManageEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objErrorIdManageEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.FunctionName);
 var strFunctionName = objErrorIdManageEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objErrorIdManageEN.Explanation !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.Explanation);
 var strExplanation = objErrorIdManageEN.Explanation.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplanation + "'");
 }
 
 if (objErrorIdManageEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.UpdDate);
 var strUpdDate = objErrorIdManageEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objErrorIdManageEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.UpdUserId);
 var strUpdUserId = objErrorIdManageEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objErrorIdManageEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.Memo);
 var strMemo = objErrorIdManageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ErrorIdManage");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objErrorIdManageEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsErrorIdManageEN objErrorIdManageEN)
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objErrorIdManageEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objErrorIdManageEN.ErrID !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.ErrID);
 var strErrID = objErrorIdManageEN.ErrID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrID + "'");
 }
 
 if (objErrorIdManageEN.ProgLevelTypeId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.ProgLevelTypeId);
 var strProgLevelTypeId = objErrorIdManageEN.ProgLevelTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLevelTypeId + "'");
 }
 
 if (objErrorIdManageEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.CodeTypeId);
 var strCodeTypeId = objErrorIdManageEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objErrorIdManageEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.FunctionName);
 var strFunctionName = objErrorIdManageEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objErrorIdManageEN.Explanation !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.Explanation);
 var strExplanation = objErrorIdManageEN.Explanation.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplanation + "'");
 }
 
 if (objErrorIdManageEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.UpdDate);
 var strUpdDate = objErrorIdManageEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objErrorIdManageEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.UpdUserId);
 var strUpdUserId = objErrorIdManageEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objErrorIdManageEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.Memo);
 var strMemo = objErrorIdManageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ErrorIdManage");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objErrorIdManageEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsErrorIdManageEN objErrorIdManageEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objErrorIdManageEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objErrorIdManageEN.ErrID !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.ErrID);
 var strErrID = objErrorIdManageEN.ErrID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrID + "'");
 }
 
 if (objErrorIdManageEN.ProgLevelTypeId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.ProgLevelTypeId);
 var strProgLevelTypeId = objErrorIdManageEN.ProgLevelTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLevelTypeId + "'");
 }
 
 if (objErrorIdManageEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.CodeTypeId);
 var strCodeTypeId = objErrorIdManageEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objErrorIdManageEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.FunctionName);
 var strFunctionName = objErrorIdManageEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objErrorIdManageEN.Explanation !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.Explanation);
 var strExplanation = objErrorIdManageEN.Explanation.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplanation + "'");
 }
 
 if (objErrorIdManageEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.UpdDate);
 var strUpdDate = objErrorIdManageEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objErrorIdManageEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.UpdUserId);
 var strUpdUserId = objErrorIdManageEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objErrorIdManageEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.Memo);
 var strMemo = objErrorIdManageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ErrorIdManage");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objErrorIdManageEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsErrorIdManageEN objErrorIdManageEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objErrorIdManageEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objErrorIdManageEN.ErrID !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.ErrID);
 var strErrID = objErrorIdManageEN.ErrID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrID + "'");
 }
 
 if (objErrorIdManageEN.ProgLevelTypeId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.ProgLevelTypeId);
 var strProgLevelTypeId = objErrorIdManageEN.ProgLevelTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLevelTypeId + "'");
 }
 
 if (objErrorIdManageEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.CodeTypeId);
 var strCodeTypeId = objErrorIdManageEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objErrorIdManageEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.FunctionName);
 var strFunctionName = objErrorIdManageEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 if (objErrorIdManageEN.Explanation !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.Explanation);
 var strExplanation = objErrorIdManageEN.Explanation.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExplanation + "'");
 }
 
 if (objErrorIdManageEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.UpdDate);
 var strUpdDate = objErrorIdManageEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objErrorIdManageEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.UpdUserId);
 var strUpdUserId = objErrorIdManageEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objErrorIdManageEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conErrorIdManage.Memo);
 var strMemo = objErrorIdManageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ErrorIdManage");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewErrorIdManages(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ErrorIdManage");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conErrorIdManage.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsErrorIdManageEN._CurrTabName ].NewRow();
objRow[conErrorIdManage.ErrID] = oRow[conErrorIdManage.ErrID].ToString().Trim(); //错误Id
objRow[conErrorIdManage.ProgLevelTypeId] = oRow[conErrorIdManage.ProgLevelTypeId].ToString().Trim(); //程序分层类型Id
objRow[conErrorIdManage.CodeTypeId] = oRow[conErrorIdManage.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conErrorIdManage.FunctionName] = oRow[conErrorIdManage.FunctionName].ToString().Trim(); //功能名称
objRow[conErrorIdManage.Explanation] = oRow[conErrorIdManage.Explanation].ToString().Trim(); //详细说明
objRow[conErrorIdManage.UpdDate] = oRow[conErrorIdManage.UpdDate].ToString().Trim(); //修改日期
objRow[conErrorIdManage.UpdUserId] = oRow[conErrorIdManage.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conErrorIdManage.Memo] = oRow[conErrorIdManage.Memo].ToString().Trim(); //说明
 objDS.Tables[clsErrorIdManageEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsErrorIdManageEN._CurrTabName);
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
 /// <param name = "objErrorIdManageEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsErrorIdManageEN objErrorIdManageEN)
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objErrorIdManageEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
strSQL = "Select * from ErrorIdManage where mId = " + ""+ objErrorIdManageEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsErrorIdManageEN._CurrTabName);
if (objDS.Tables[clsErrorIdManageEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objErrorIdManageEN.mId+"");
return false;
}
objRow = objDS.Tables[clsErrorIdManageEN._CurrTabName].Rows[0];
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ErrID))
 {
objRow[conErrorIdManage.ErrID] = objErrorIdManageEN.ErrID; //错误Id
 }
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ProgLevelTypeId))
 {
objRow[conErrorIdManage.ProgLevelTypeId] = objErrorIdManageEN.ProgLevelTypeId; //程序分层类型Id
 }
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.CodeTypeId))
 {
objRow[conErrorIdManage.CodeTypeId] = objErrorIdManageEN.CodeTypeId; //代码类型Id
 }
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.FunctionName))
 {
objRow[conErrorIdManage.FunctionName] = objErrorIdManageEN.FunctionName; //功能名称
 }
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Explanation))
 {
objRow[conErrorIdManage.Explanation] = objErrorIdManageEN.Explanation; //详细说明
 }
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdDate))
 {
objRow[conErrorIdManage.UpdDate] = objErrorIdManageEN.UpdDate; //修改日期
 }
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdUserId))
 {
objRow[conErrorIdManage.UpdUserId] = objErrorIdManageEN.UpdUserId; //修改用户Id
 }
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Memo))
 {
objRow[conErrorIdManage.Memo] = objErrorIdManageEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsErrorIdManageEN._CurrTabName);
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
 /// <param name = "objErrorIdManageEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsErrorIdManageEN objErrorIdManageEN)
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objErrorIdManageEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ErrorIdManage Set ");
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ErrID))
 {
 if (objErrorIdManageEN.ErrID !=  null)
 {
 var strErrID = objErrorIdManageEN.ErrID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrID, conErrorIdManage.ErrID); //错误Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.ErrID); //错误Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ProgLevelTypeId))
 {
 if (objErrorIdManageEN.ProgLevelTypeId !=  null)
 {
 var strProgLevelTypeId = objErrorIdManageEN.ProgLevelTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLevelTypeId, conErrorIdManage.ProgLevelTypeId); //程序分层类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.ProgLevelTypeId); //程序分层类型Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.CodeTypeId))
 {
 if (objErrorIdManageEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objErrorIdManageEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conErrorIdManage.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.CodeTypeId); //代码类型Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.FunctionName))
 {
 if (objErrorIdManageEN.FunctionName !=  null)
 {
 var strFunctionName = objErrorIdManageEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conErrorIdManage.FunctionName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.FunctionName); //功能名称
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Explanation))
 {
 if (objErrorIdManageEN.Explanation !=  null)
 {
 var strExplanation = objErrorIdManageEN.Explanation.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExplanation, conErrorIdManage.Explanation); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.Explanation); //详细说明
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdDate))
 {
 if (objErrorIdManageEN.UpdDate !=  null)
 {
 var strUpdDate = objErrorIdManageEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conErrorIdManage.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.UpdDate); //修改日期
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdUserId))
 {
 if (objErrorIdManageEN.UpdUserId !=  null)
 {
 var strUpdUserId = objErrorIdManageEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conErrorIdManage.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.UpdUserId); //修改用户Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Memo))
 {
 if (objErrorIdManageEN.Memo !=  null)
 {
 var strMemo = objErrorIdManageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conErrorIdManage.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objErrorIdManageEN.mId); 
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
 /// <param name = "objErrorIdManageEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsErrorIdManageEN objErrorIdManageEN, string strCondition)
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objErrorIdManageEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ErrorIdManage Set ");
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ErrID))
 {
 if (objErrorIdManageEN.ErrID !=  null)
 {
 var strErrID = objErrorIdManageEN.ErrID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrID = '{0}',", strErrID); //错误Id
 }
 else
 {
 sbSQL.Append(" ErrID = null,"); //错误Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ProgLevelTypeId))
 {
 if (objErrorIdManageEN.ProgLevelTypeId !=  null)
 {
 var strProgLevelTypeId = objErrorIdManageEN.ProgLevelTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLevelTypeId = '{0}',", strProgLevelTypeId); //程序分层类型Id
 }
 else
 {
 sbSQL.Append(" ProgLevelTypeId = null,"); //程序分层类型Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.CodeTypeId))
 {
 if (objErrorIdManageEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objErrorIdManageEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.FunctionName))
 {
 if (objErrorIdManageEN.FunctionName !=  null)
 {
 var strFunctionName = objErrorIdManageEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //功能名称
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //功能名称
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Explanation))
 {
 if (objErrorIdManageEN.Explanation !=  null)
 {
 var strExplanation = objErrorIdManageEN.Explanation.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Explanation = '{0}',", strExplanation); //详细说明
 }
 else
 {
 sbSQL.Append(" Explanation = null,"); //详细说明
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdDate))
 {
 if (objErrorIdManageEN.UpdDate !=  null)
 {
 var strUpdDate = objErrorIdManageEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdUserId))
 {
 if (objErrorIdManageEN.UpdUserId !=  null)
 {
 var strUpdUserId = objErrorIdManageEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Memo))
 {
 if (objErrorIdManageEN.Memo !=  null)
 {
 var strMemo = objErrorIdManageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objErrorIdManageEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsErrorIdManageEN objErrorIdManageEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objErrorIdManageEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ErrorIdManage Set ");
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ErrID))
 {
 if (objErrorIdManageEN.ErrID !=  null)
 {
 var strErrID = objErrorIdManageEN.ErrID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrID = '{0}',", strErrID); //错误Id
 }
 else
 {
 sbSQL.Append(" ErrID = null,"); //错误Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ProgLevelTypeId))
 {
 if (objErrorIdManageEN.ProgLevelTypeId !=  null)
 {
 var strProgLevelTypeId = objErrorIdManageEN.ProgLevelTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLevelTypeId = '{0}',", strProgLevelTypeId); //程序分层类型Id
 }
 else
 {
 sbSQL.Append(" ProgLevelTypeId = null,"); //程序分层类型Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.CodeTypeId))
 {
 if (objErrorIdManageEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objErrorIdManageEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.FunctionName))
 {
 if (objErrorIdManageEN.FunctionName !=  null)
 {
 var strFunctionName = objErrorIdManageEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //功能名称
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //功能名称
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Explanation))
 {
 if (objErrorIdManageEN.Explanation !=  null)
 {
 var strExplanation = objErrorIdManageEN.Explanation.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Explanation = '{0}',", strExplanation); //详细说明
 }
 else
 {
 sbSQL.Append(" Explanation = null,"); //详细说明
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdDate))
 {
 if (objErrorIdManageEN.UpdDate !=  null)
 {
 var strUpdDate = objErrorIdManageEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdUserId))
 {
 if (objErrorIdManageEN.UpdUserId !=  null)
 {
 var strUpdUserId = objErrorIdManageEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Memo))
 {
 if (objErrorIdManageEN.Memo !=  null)
 {
 var strMemo = objErrorIdManageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objErrorIdManageEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsErrorIdManageEN objErrorIdManageEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objErrorIdManageEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objErrorIdManageEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objErrorIdManageEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ErrorIdManage Set ");
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ErrID))
 {
 if (objErrorIdManageEN.ErrID !=  null)
 {
 var strErrID = objErrorIdManageEN.ErrID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrID, conErrorIdManage.ErrID); //错误Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.ErrID); //错误Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.ProgLevelTypeId))
 {
 if (objErrorIdManageEN.ProgLevelTypeId !=  null)
 {
 var strProgLevelTypeId = objErrorIdManageEN.ProgLevelTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLevelTypeId, conErrorIdManage.ProgLevelTypeId); //程序分层类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.ProgLevelTypeId); //程序分层类型Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.CodeTypeId))
 {
 if (objErrorIdManageEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objErrorIdManageEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conErrorIdManage.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.CodeTypeId); //代码类型Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.FunctionName))
 {
 if (objErrorIdManageEN.FunctionName !=  null)
 {
 var strFunctionName = objErrorIdManageEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conErrorIdManage.FunctionName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.FunctionName); //功能名称
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Explanation))
 {
 if (objErrorIdManageEN.Explanation !=  null)
 {
 var strExplanation = objErrorIdManageEN.Explanation.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExplanation, conErrorIdManage.Explanation); //详细说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.Explanation); //详细说明
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdDate))
 {
 if (objErrorIdManageEN.UpdDate !=  null)
 {
 var strUpdDate = objErrorIdManageEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conErrorIdManage.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.UpdDate); //修改日期
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.UpdUserId))
 {
 if (objErrorIdManageEN.UpdUserId !=  null)
 {
 var strUpdUserId = objErrorIdManageEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conErrorIdManage.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.UpdUserId); //修改用户Id
 }
 }
 
 if (objErrorIdManageEN.IsUpdated(conErrorIdManage.Memo))
 {
 if (objErrorIdManageEN.Memo !=  null)
 {
 var strMemo = objErrorIdManageEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conErrorIdManage.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conErrorIdManage.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objErrorIdManageEN.mId); 
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ErrorIdManage_Delete", values);
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
//删除ErrorIdManage本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ErrorIdManage where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelErrorIdManage(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
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
//删除ErrorIdManage本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ErrorIdManage where mId in (" + strKeyList + ")";
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
//删除ErrorIdManage本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ErrorIdManage where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelErrorIdManage(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsErrorIdManageDA: DelErrorIdManage)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ErrorIdManage where " + strCondition ;
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
public bool DelErrorIdManageWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsErrorIdManageDA: DelErrorIdManageWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ErrorIdManage where " + strCondition ;
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
 /// <param name = "objErrorIdManageENS">源对象</param>
 /// <param name = "objErrorIdManageENT">目标对象</param>
public void CopyTo(clsErrorIdManageEN objErrorIdManageENS, clsErrorIdManageEN objErrorIdManageENT)
{
objErrorIdManageENT.mId = objErrorIdManageENS.mId; //mId
objErrorIdManageENT.ErrID = objErrorIdManageENS.ErrID; //错误Id
objErrorIdManageENT.ProgLevelTypeId = objErrorIdManageENS.ProgLevelTypeId; //程序分层类型Id
objErrorIdManageENT.CodeTypeId = objErrorIdManageENS.CodeTypeId; //代码类型Id
objErrorIdManageENT.FunctionName = objErrorIdManageENS.FunctionName; //功能名称
objErrorIdManageENT.Explanation = objErrorIdManageENS.Explanation; //详细说明
objErrorIdManageENT.UpdDate = objErrorIdManageENS.UpdDate; //修改日期
objErrorIdManageENT.UpdUserId = objErrorIdManageENS.UpdUserId; //修改用户Id
objErrorIdManageENT.Memo = objErrorIdManageENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsErrorIdManageEN objErrorIdManageEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objErrorIdManageEN.ErrID, conErrorIdManage.ErrID);
clsCheckSql.CheckFieldNotNull(objErrorIdManageEN.FunctionName, conErrorIdManage.FunctionName);
//检查字段长度
clsCheckSql.CheckFieldLen(objErrorIdManageEN.ErrID, 10, conErrorIdManage.ErrID);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.ProgLevelTypeId, 2, conErrorIdManage.ProgLevelTypeId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.CodeTypeId, 4, conErrorIdManage.CodeTypeId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.FunctionName, 200, conErrorIdManage.FunctionName);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.Explanation, 1000, conErrorIdManage.Explanation);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.UpdDate, 20, conErrorIdManage.UpdDate);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.UpdUserId, 20, conErrorIdManage.UpdUserId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.Memo, 1000, conErrorIdManage.Memo);
//检查字段外键固定长度
 objErrorIdManageEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsErrorIdManageEN objErrorIdManageEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objErrorIdManageEN.ErrID, 10, conErrorIdManage.ErrID);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.ProgLevelTypeId, 2, conErrorIdManage.ProgLevelTypeId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.CodeTypeId, 4, conErrorIdManage.CodeTypeId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.FunctionName, 200, conErrorIdManage.FunctionName);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.Explanation, 1000, conErrorIdManage.Explanation);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.UpdDate, 20, conErrorIdManage.UpdDate);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.UpdUserId, 20, conErrorIdManage.UpdUserId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.Memo, 1000, conErrorIdManage.Memo);
//检查外键字段长度
 objErrorIdManageEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsErrorIdManageEN objErrorIdManageEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objErrorIdManageEN.ErrID, 10, conErrorIdManage.ErrID);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.ProgLevelTypeId, 2, conErrorIdManage.ProgLevelTypeId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.CodeTypeId, 4, conErrorIdManage.CodeTypeId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.FunctionName, 200, conErrorIdManage.FunctionName);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.Explanation, 1000, conErrorIdManage.Explanation);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.UpdDate, 20, conErrorIdManage.UpdDate);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.UpdUserId, 20, conErrorIdManage.UpdUserId);
clsCheckSql.CheckFieldLen(objErrorIdManageEN.Memo, 1000, conErrorIdManage.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objErrorIdManageEN.ErrID, conErrorIdManage.ErrID);
clsCheckSql.CheckSqlInjection4Field(objErrorIdManageEN.ProgLevelTypeId, conErrorIdManage.ProgLevelTypeId);
clsCheckSql.CheckSqlInjection4Field(objErrorIdManageEN.CodeTypeId, conErrorIdManage.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objErrorIdManageEN.FunctionName, conErrorIdManage.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objErrorIdManageEN.Explanation, conErrorIdManage.Explanation);
clsCheckSql.CheckSqlInjection4Field(objErrorIdManageEN.UpdDate, conErrorIdManage.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objErrorIdManageEN.UpdUserId, conErrorIdManage.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objErrorIdManageEN.Memo, conErrorIdManage.Memo);
//检查外键字段长度
 objErrorIdManageEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ErrorIdManage(错误Id管理),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objErrorIdManageEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsErrorIdManageEN objErrorIdManageEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objErrorIdManageEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objErrorIdManageEN.CodeTypeId);
}
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objErrorIdManageEN.FunctionName);
 if (objErrorIdManageEN.Explanation == null)
{
 sbCondition.AppendFormat(" and Explanation is null");
}
else
{
 sbCondition.AppendFormat(" and Explanation = '{0}'", objErrorIdManageEN.Explanation);
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsErrorIdManageEN._CurrTabName);
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsErrorIdManageEN._CurrTabName, strCondition);
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
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
 objSQL = clsErrorIdManageDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}