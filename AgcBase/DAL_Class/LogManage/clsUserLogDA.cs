
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserLogDA
 表名:UserLog(00050130)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:50
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
 /// 用户日志(UserLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserLogDA : clsCommBase4DA
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
 return clsUserLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserLogDA: GetDataTable_UserLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserLog.* " + 
$"from UserLog " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserLog.mId not in " + 
$"(Select top {intTop_In} UserLog.mId from UserLog " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserLog where {1} and mId not in (Select top {2} mId from UserLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserLog where {1} and mId not in (Select top {3} mId from UserLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserLog.* " + 
$"from UserLog " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserLog.mId not in " + 
$"(Select top {intTop_In} UserLog.mId from UserLog " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserLog where {1} and mId not in (Select top {2} mId from UserLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserLog where {1} and mId not in (Select top {3} mId from UserLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserLogDA:GetObjLst)", objException.Message));
}
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = TransNullToInt(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = TransNullToBool(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = TransNullToInt(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserLogDA: GetObjLst)", objException.Message));
}
objUserLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserLogEN);
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
public List<clsUserLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserLogEN> arrObjLst = new List<clsUserLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = TransNullToInt(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = TransNullToBool(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = TransNullToInt(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserLogDA: GetObjLst)", objException.Message));
}
objUserLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserLog(ref clsUserLogEN objUserLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where mId = " + ""+ objUserLogEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserLogEN.mId = TransNullToInt(objDT.Rows[0][conUserLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserLogEN.UserId = objDT.Rows[0][conUserLog.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserLogEN.LoginTime = objDT.Rows[0][conUserLog.LoginTime].ToString().Trim(); //登陆时间(字段类型:varchar,字段长度:6,是否可空:True)
 objUserLogEN.LoginDate = objDT.Rows[0][conUserLog.LoginDate].ToString().Trim(); //登陆日期(字段类型:varchar,字段长度:8,是否可空:True)
 objUserLogEN.UserIp = objDT.Rows[0][conUserLog.UserIp].ToString().Trim(); //用户IP(字段类型:varchar,字段长度:40,是否可空:True)
 objUserLogEN.ObjectTable = objDT.Rows[0][conUserLog.ObjectTable].ToString().Trim(); //对象表(字段类型:varchar,字段长度:50,是否可空:True)
 objUserLogEN.UsedValue = objDT.Rows[0][conUserLog.UsedValue].ToString().Trim(); //使用值(字段类型:varchar,字段长度:50,是否可空:True)
 objUserLogEN.UpdDate = objDT.Rows[0][conUserLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserLogEN.Memo = objDT.Rows[0][conUserLog.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objUserLogEN.IsDeleted = TransNullToBool(objDT.Rows[0][conUserLog.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objUserLogEN.OrderNum = TransNullToInt(objDT.Rows[0][conUserLog.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objUserLogEN.DeletedDate = objDT.Rows[0][conUserLog.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserLogDA: GetUserLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsUserLogEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
 objUserLogEN.mId = Int32.Parse(objRow[conUserLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间(字段类型:varchar,字段长度:6,是否可空:True)
 objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期(字段类型:varchar,字段长度:8,是否可空:True)
 objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP(字段类型:varchar,字段长度:40,是否可空:True)
 objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表(字段类型:varchar,字段长度:50,是否可空:True)
 objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值(字段类型:varchar,字段长度:50,是否可空:True)
 objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objUserLogEN.IsDeleted = clsEntityBase2.TransNullToBool_S(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除(字段类型:bit,字段长度:1,是否可空:True)
 objUserLogEN.OrderNum = Int32.Parse(objRow[conUserLog.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserLogDA: GetObjBymId)", objException.Message));
}
return objUserLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserLogEN objUserLogEN = new clsUserLogEN()
{
mId = TransNullToInt(objRow[conUserLog.mId].ToString().Trim()), //mId
UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(), //用户Id
LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(), //登陆时间
LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(), //登陆日期
UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(), //用户IP
ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(), //对象表
UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(), //使用值
UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(), //说明
IsDeleted = TransNullToBool(objRow[conUserLog.IsDeleted].ToString().Trim()), //是否删除
OrderNum = TransNullToInt(objRow[conUserLog.OrderNum].ToString().Trim()), //序号
DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim() //删除日期
};
objUserLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = TransNullToInt(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = TransNullToBool(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = TransNullToInt(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserLogDA: GetObjByDataRowUserLog)", objException.Message));
}
objUserLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserLogEN objUserLogEN = new clsUserLogEN();
try
{
objUserLogEN.mId = TransNullToInt(objRow[conUserLog.mId].ToString().Trim()); //mId
objUserLogEN.UserId = objRow[conUserLog.UserId] == DBNull.Value ? null : objRow[conUserLog.UserId].ToString().Trim(); //用户Id
objUserLogEN.LoginTime = objRow[conUserLog.LoginTime] == DBNull.Value ? null : objRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objUserLogEN.LoginDate = objRow[conUserLog.LoginDate] == DBNull.Value ? null : objRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objUserLogEN.UserIp = objRow[conUserLog.UserIp] == DBNull.Value ? null : objRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objUserLogEN.ObjectTable = objRow[conUserLog.ObjectTable] == DBNull.Value ? null : objRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objUserLogEN.UsedValue = objRow[conUserLog.UsedValue] == DBNull.Value ? null : objRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objUserLogEN.UpdDate = objRow[conUserLog.UpdDate] == DBNull.Value ? null : objRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objUserLogEN.Memo = objRow[conUserLog.Memo] == DBNull.Value ? null : objRow[conUserLog.Memo].ToString().Trim(); //说明
objUserLogEN.IsDeleted = TransNullToBool(objRow[conUserLog.IsDeleted].ToString().Trim()); //是否删除
objUserLogEN.OrderNum = TransNullToInt(objRow[conUserLog.OrderNum].ToString().Trim()); //序号
objUserLogEN.DeletedDate = objRow[conUserLog.DeletedDate] == DBNull.Value ? null : objRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserLogDA: GetObjByDataRow)", objException.Message));
}
objUserLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserLogEN;
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
objSQL = clsUserLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserLogEN._CurrTabName, conUserLog.mId, 8, "");
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
objSQL = clsUserLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserLogEN._CurrTabName, conUserLog.mId, 8, strPrefix);
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from UserLog where " + strCondition;
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from UserLog where " + strCondition;
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserLog", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserLog", strCondition))
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
objSQL = clsUserLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserLogEN objUserLogEN)
 {
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserLog");
objRow = objDS.Tables["UserLog"].NewRow();
 if (objUserLogEN.UserId !=  "")
 {
objRow[conUserLog.UserId] = objUserLogEN.UserId; //用户Id
 }
 if (objUserLogEN.LoginTime !=  "")
 {
objRow[conUserLog.LoginTime] = objUserLogEN.LoginTime; //登陆时间
 }
 if (objUserLogEN.LoginDate !=  "")
 {
objRow[conUserLog.LoginDate] = objUserLogEN.LoginDate; //登陆日期
 }
 if (objUserLogEN.UserIp !=  "")
 {
objRow[conUserLog.UserIp] = objUserLogEN.UserIp; //用户IP
 }
 if (objUserLogEN.ObjectTable !=  "")
 {
objRow[conUserLog.ObjectTable] = objUserLogEN.ObjectTable; //对象表
 }
 if (objUserLogEN.UsedValue !=  "")
 {
objRow[conUserLog.UsedValue] = objUserLogEN.UsedValue; //使用值
 }
 if (objUserLogEN.UpdDate !=  "")
 {
objRow[conUserLog.UpdDate] = objUserLogEN.UpdDate; //修改日期
 }
 if (objUserLogEN.Memo !=  "")
 {
objRow[conUserLog.Memo] = objUserLogEN.Memo; //说明
 }
objRow[conUserLog.IsDeleted] = objUserLogEN.IsDeleted; //是否删除
objRow[conUserLog.OrderNum] = objUserLogEN.OrderNum; //序号
 if (objUserLogEN.DeletedDate !=  "")
 {
objRow[conUserLog.DeletedDate] = objUserLogEN.DeletedDate; //删除日期
 }
objDS.Tables[clsUserLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserLogEN._CurrTabName);
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
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserLogEN objUserLogEN)
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UserId);
 var strUserId = objUserLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.LoginTime);
 var strLoginTime = objUserLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objUserLogEN.LoginDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.LoginDate);
 var strLoginDate = objUserLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginDate + "'");
 }
 
 if (objUserLogEN.UserIp !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UserIp);
 var strUserIp = objUserLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserIp + "'");
 }
 
 if (objUserLogEN.ObjectTable !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.ObjectTable);
 var strObjectTable = objUserLogEN.ObjectTable.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectTable + "'");
 }
 
 if (objUserLogEN.UsedValue !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UsedValue);
 var strUsedValue = objUserLogEN.UsedValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUsedValue + "'");
 }
 
 if (objUserLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UpdDate);
 var strUpdDate = objUserLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.Memo);
 var strMemo = objUserLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conUserLog.IsDeleted);
 arrValueListForInsert.Add("'" + (objUserLogEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserLog.OrderNum);
 arrValueListForInsert.Add(objUserLogEN.OrderNum.ToString());
 
 if (objUserLogEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.DeletedDate);
 var strDeletedDate = objUserLogEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserLogEN objUserLogEN)
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UserId);
 var strUserId = objUserLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.LoginTime);
 var strLoginTime = objUserLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objUserLogEN.LoginDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.LoginDate);
 var strLoginDate = objUserLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginDate + "'");
 }
 
 if (objUserLogEN.UserIp !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UserIp);
 var strUserIp = objUserLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserIp + "'");
 }
 
 if (objUserLogEN.ObjectTable !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.ObjectTable);
 var strObjectTable = objUserLogEN.ObjectTable.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectTable + "'");
 }
 
 if (objUserLogEN.UsedValue !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UsedValue);
 var strUsedValue = objUserLogEN.UsedValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUsedValue + "'");
 }
 
 if (objUserLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UpdDate);
 var strUpdDate = objUserLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.Memo);
 var strMemo = objUserLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conUserLog.IsDeleted);
 arrValueListForInsert.Add("'" + (objUserLogEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserLog.OrderNum);
 arrValueListForInsert.Add(objUserLogEN.OrderNum.ToString());
 
 if (objUserLogEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.DeletedDate);
 var strDeletedDate = objUserLogEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserLogEN objUserLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UserId);
 var strUserId = objUserLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.LoginTime);
 var strLoginTime = objUserLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objUserLogEN.LoginDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.LoginDate);
 var strLoginDate = objUserLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginDate + "'");
 }
 
 if (objUserLogEN.UserIp !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UserIp);
 var strUserIp = objUserLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserIp + "'");
 }
 
 if (objUserLogEN.ObjectTable !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.ObjectTable);
 var strObjectTable = objUserLogEN.ObjectTable.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectTable + "'");
 }
 
 if (objUserLogEN.UsedValue !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UsedValue);
 var strUsedValue = objUserLogEN.UsedValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUsedValue + "'");
 }
 
 if (objUserLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UpdDate);
 var strUpdDate = objUserLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.Memo);
 var strMemo = objUserLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conUserLog.IsDeleted);
 arrValueListForInsert.Add("'" + (objUserLogEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserLog.OrderNum);
 arrValueListForInsert.Add(objUserLogEN.OrderNum.ToString());
 
 if (objUserLogEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.DeletedDate);
 var strDeletedDate = objUserLogEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserLogEN objUserLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UserId);
 var strUserId = objUserLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.LoginTime);
 var strLoginTime = objUserLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objUserLogEN.LoginDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.LoginDate);
 var strLoginDate = objUserLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginDate + "'");
 }
 
 if (objUserLogEN.UserIp !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UserIp);
 var strUserIp = objUserLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserIp + "'");
 }
 
 if (objUserLogEN.ObjectTable !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.ObjectTable);
 var strObjectTable = objUserLogEN.ObjectTable.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectTable + "'");
 }
 
 if (objUserLogEN.UsedValue !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UsedValue);
 var strUsedValue = objUserLogEN.UsedValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUsedValue + "'");
 }
 
 if (objUserLogEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.UpdDate);
 var strUpdDate = objUserLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.Memo);
 var strMemo = objUserLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conUserLog.IsDeleted);
 arrValueListForInsert.Add("'" + (objUserLogEN.IsDeleted  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conUserLog.OrderNum);
 arrValueListForInsert.Add(objUserLogEN.OrderNum.ToString());
 
 if (objUserLogEN.DeletedDate !=  null)
 {
 arrFieldListForInsert.Add(conUserLog.DeletedDate);
 var strDeletedDate = objUserLogEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDeletedDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserLog");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conUserLog.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserLogEN._CurrTabName ].NewRow();
objRow[conUserLog.UserId] = oRow[conUserLog.UserId].ToString().Trim(); //用户Id
objRow[conUserLog.LoginTime] = oRow[conUserLog.LoginTime].ToString().Trim(); //登陆时间
objRow[conUserLog.LoginDate] = oRow[conUserLog.LoginDate].ToString().Trim(); //登陆日期
objRow[conUserLog.UserIp] = oRow[conUserLog.UserIp].ToString().Trim(); //用户IP
objRow[conUserLog.ObjectTable] = oRow[conUserLog.ObjectTable].ToString().Trim(); //对象表
objRow[conUserLog.UsedValue] = oRow[conUserLog.UsedValue].ToString().Trim(); //使用值
objRow[conUserLog.UpdDate] = oRow[conUserLog.UpdDate].ToString().Trim(); //修改日期
objRow[conUserLog.Memo] = oRow[conUserLog.Memo].ToString().Trim(); //说明
objRow[conUserLog.IsDeleted] = oRow[conUserLog.IsDeleted].ToString().Trim(); //是否删除
objRow[conUserLog.OrderNum] = oRow[conUserLog.OrderNum].ToString().Trim(); //序号
objRow[conUserLog.DeletedDate] = oRow[conUserLog.DeletedDate].ToString().Trim(); //删除日期
 objDS.Tables[clsUserLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserLogEN._CurrTabName);
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
 /// <param name = "objUserLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserLogEN objUserLogEN)
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
strSQL = "Select * from UserLog where mId = " + ""+ objUserLogEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserLogEN._CurrTabName);
if (objDS.Tables[clsUserLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objUserLogEN.mId+"");
return false;
}
objRow = objDS.Tables[clsUserLogEN._CurrTabName].Rows[0];
 if (objUserLogEN.IsUpdated(conUserLog.UserId))
 {
objRow[conUserLog.UserId] = objUserLogEN.UserId; //用户Id
 }
 if (objUserLogEN.IsUpdated(conUserLog.LoginTime))
 {
objRow[conUserLog.LoginTime] = objUserLogEN.LoginTime; //登陆时间
 }
 if (objUserLogEN.IsUpdated(conUserLog.LoginDate))
 {
objRow[conUserLog.LoginDate] = objUserLogEN.LoginDate; //登陆日期
 }
 if (objUserLogEN.IsUpdated(conUserLog.UserIp))
 {
objRow[conUserLog.UserIp] = objUserLogEN.UserIp; //用户IP
 }
 if (objUserLogEN.IsUpdated(conUserLog.ObjectTable))
 {
objRow[conUserLog.ObjectTable] = objUserLogEN.ObjectTable; //对象表
 }
 if (objUserLogEN.IsUpdated(conUserLog.UsedValue))
 {
objRow[conUserLog.UsedValue] = objUserLogEN.UsedValue; //使用值
 }
 if (objUserLogEN.IsUpdated(conUserLog.UpdDate))
 {
objRow[conUserLog.UpdDate] = objUserLogEN.UpdDate; //修改日期
 }
 if (objUserLogEN.IsUpdated(conUserLog.Memo))
 {
objRow[conUserLog.Memo] = objUserLogEN.Memo; //说明
 }
 if (objUserLogEN.IsUpdated(conUserLog.IsDeleted))
 {
objRow[conUserLog.IsDeleted] = objUserLogEN.IsDeleted; //是否删除
 }
 if (objUserLogEN.IsUpdated(conUserLog.OrderNum))
 {
objRow[conUserLog.OrderNum] = objUserLogEN.OrderNum; //序号
 }
 if (objUserLogEN.IsUpdated(conUserLog.DeletedDate))
 {
objRow[conUserLog.DeletedDate] = objUserLogEN.DeletedDate; //删除日期
 }
try
{
objDA.Update(objDS, clsUserLogEN._CurrTabName);
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
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserLogEN objUserLogEN)
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserLog Set ");
 
 if (objUserLogEN.IsUpdated(conUserLog.UserId))
 {
 if (objUserLogEN.UserId !=  null)
 {
 var strUserId = objUserLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserLog.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.UserId); //用户Id
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.LoginTime))
 {
 if (objUserLogEN.LoginTime !=  null)
 {
 var strLoginTime = objUserLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginTime, conUserLog.LoginTime); //登陆时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.LoginTime); //登陆时间
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.LoginDate))
 {
 if (objUserLogEN.LoginDate !=  null)
 {
 var strLoginDate = objUserLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginDate, conUserLog.LoginDate); //登陆日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.LoginDate); //登陆日期
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UserIp))
 {
 if (objUserLogEN.UserIp !=  null)
 {
 var strUserIp = objUserLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserIp, conUserLog.UserIp); //用户IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.UserIp); //用户IP
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.ObjectTable))
 {
 if (objUserLogEN.ObjectTable !=  null)
 {
 var strObjectTable = objUserLogEN.ObjectTable.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectTable, conUserLog.ObjectTable); //对象表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.ObjectTable); //对象表
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UsedValue))
 {
 if (objUserLogEN.UsedValue !=  null)
 {
 var strUsedValue = objUserLogEN.UsedValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUsedValue, conUserLog.UsedValue); //使用值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.UsedValue); //使用值
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UpdDate))
 {
 if (objUserLogEN.UpdDate !=  null)
 {
 var strUpdDate = objUserLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserLog.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.UpdDate); //修改日期
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.Memo))
 {
 if (objUserLogEN.Memo !=  null)
 {
 var strMemo = objUserLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserLog.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.Memo); //说明
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserLogEN.IsDeleted == true?"1":"0", conUserLog.IsDeleted); //是否删除
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objUserLogEN.OrderNum, conUserLog.OrderNum); //序号
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.DeletedDate))
 {
 if (objUserLogEN.DeletedDate !=  null)
 {
 var strDeletedDate = objUserLogEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDeletedDate, conUserLog.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.DeletedDate); //删除日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserLogEN.mId); 
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
 /// <param name = "objUserLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserLogEN objUserLogEN, string strCondition)
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserLog Set ");
 
 if (objUserLogEN.IsUpdated(conUserLog.UserId))
 {
 if (objUserLogEN.UserId !=  null)
 {
 var strUserId = objUserLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.LoginTime))
 {
 if (objUserLogEN.LoginTime !=  null)
 {
 var strLoginTime = objUserLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginTime = '{0}',", strLoginTime); //登陆时间
 }
 else
 {
 sbSQL.Append(" LoginTime = null,"); //登陆时间
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.LoginDate))
 {
 if (objUserLogEN.LoginDate !=  null)
 {
 var strLoginDate = objUserLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginDate = '{0}',", strLoginDate); //登陆日期
 }
 else
 {
 sbSQL.Append(" LoginDate = null,"); //登陆日期
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UserIp))
 {
 if (objUserLogEN.UserIp !=  null)
 {
 var strUserIp = objUserLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserIp = '{0}',", strUserIp); //用户IP
 }
 else
 {
 sbSQL.Append(" UserIp = null,"); //用户IP
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.ObjectTable))
 {
 if (objUserLogEN.ObjectTable !=  null)
 {
 var strObjectTable = objUserLogEN.ObjectTable.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectTable = '{0}',", strObjectTable); //对象表
 }
 else
 {
 sbSQL.Append(" ObjectTable = null,"); //对象表
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UsedValue))
 {
 if (objUserLogEN.UsedValue !=  null)
 {
 var strUsedValue = objUserLogEN.UsedValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UsedValue = '{0}',", strUsedValue); //使用值
 }
 else
 {
 sbSQL.Append(" UsedValue = null,"); //使用值
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UpdDate))
 {
 if (objUserLogEN.UpdDate !=  null)
 {
 var strUpdDate = objUserLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.Memo))
 {
 if (objUserLogEN.Memo !=  null)
 {
 var strMemo = objUserLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objUserLogEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objUserLogEN.OrderNum); //序号
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.DeletedDate))
 {
 if (objUserLogEN.DeletedDate !=  null)
 {
 var strDeletedDate = objUserLogEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", strDeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
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
 /// <param name = "objUserLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserLogEN objUserLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserLog Set ");
 
 if (objUserLogEN.IsUpdated(conUserLog.UserId))
 {
 if (objUserLogEN.UserId !=  null)
 {
 var strUserId = objUserLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.LoginTime))
 {
 if (objUserLogEN.LoginTime !=  null)
 {
 var strLoginTime = objUserLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginTime = '{0}',", strLoginTime); //登陆时间
 }
 else
 {
 sbSQL.Append(" LoginTime = null,"); //登陆时间
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.LoginDate))
 {
 if (objUserLogEN.LoginDate !=  null)
 {
 var strLoginDate = objUserLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginDate = '{0}',", strLoginDate); //登陆日期
 }
 else
 {
 sbSQL.Append(" LoginDate = null,"); //登陆日期
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UserIp))
 {
 if (objUserLogEN.UserIp !=  null)
 {
 var strUserIp = objUserLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserIp = '{0}',", strUserIp); //用户IP
 }
 else
 {
 sbSQL.Append(" UserIp = null,"); //用户IP
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.ObjectTable))
 {
 if (objUserLogEN.ObjectTable !=  null)
 {
 var strObjectTable = objUserLogEN.ObjectTable.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectTable = '{0}',", strObjectTable); //对象表
 }
 else
 {
 sbSQL.Append(" ObjectTable = null,"); //对象表
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UsedValue))
 {
 if (objUserLogEN.UsedValue !=  null)
 {
 var strUsedValue = objUserLogEN.UsedValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UsedValue = '{0}',", strUsedValue); //使用值
 }
 else
 {
 sbSQL.Append(" UsedValue = null,"); //使用值
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UpdDate))
 {
 if (objUserLogEN.UpdDate !=  null)
 {
 var strUpdDate = objUserLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.Memo))
 {
 if (objUserLogEN.Memo !=  null)
 {
 var strMemo = objUserLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.IsDeleted))
 {
 sbSQL.AppendFormat(" IsDeleted = '{0}',", objUserLogEN.IsDeleted == true?"1":"0"); //是否删除
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objUserLogEN.OrderNum); //序号
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.DeletedDate))
 {
 if (objUserLogEN.DeletedDate !=  null)
 {
 var strDeletedDate = objUserLogEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DeletedDate = '{0}',", strDeletedDate); //删除日期
 }
 else
 {
 sbSQL.Append(" DeletedDate = null,"); //删除日期
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
 /// <param name = "objUserLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserLogEN objUserLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserLogEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserLog Set ");
 
 if (objUserLogEN.IsUpdated(conUserLog.UserId))
 {
 if (objUserLogEN.UserId !=  null)
 {
 var strUserId = objUserLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserLog.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.UserId); //用户Id
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.LoginTime))
 {
 if (objUserLogEN.LoginTime !=  null)
 {
 var strLoginTime = objUserLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginTime, conUserLog.LoginTime); //登陆时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.LoginTime); //登陆时间
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.LoginDate))
 {
 if (objUserLogEN.LoginDate !=  null)
 {
 var strLoginDate = objUserLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginDate, conUserLog.LoginDate); //登陆日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.LoginDate); //登陆日期
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UserIp))
 {
 if (objUserLogEN.UserIp !=  null)
 {
 var strUserIp = objUserLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserIp, conUserLog.UserIp); //用户IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.UserIp); //用户IP
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.ObjectTable))
 {
 if (objUserLogEN.ObjectTable !=  null)
 {
 var strObjectTable = objUserLogEN.ObjectTable.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectTable, conUserLog.ObjectTable); //对象表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.ObjectTable); //对象表
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UsedValue))
 {
 if (objUserLogEN.UsedValue !=  null)
 {
 var strUsedValue = objUserLogEN.UsedValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUsedValue, conUserLog.UsedValue); //使用值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.UsedValue); //使用值
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.UpdDate))
 {
 if (objUserLogEN.UpdDate !=  null)
 {
 var strUpdDate = objUserLogEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserLog.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.UpdDate); //修改日期
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.Memo))
 {
 if (objUserLogEN.Memo !=  null)
 {
 var strMemo = objUserLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserLog.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.Memo); //说明
 }
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.IsDeleted))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserLogEN.IsDeleted == true?"1":"0", conUserLog.IsDeleted); //是否删除
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objUserLogEN.OrderNum, conUserLog.OrderNum); //序号
 }
 
 if (objUserLogEN.IsUpdated(conUserLog.DeletedDate))
 {
 if (objUserLogEN.DeletedDate !=  null)
 {
 var strDeletedDate = objUserLogEN.DeletedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDeletedDate, conUserLog.DeletedDate); //删除日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserLog.DeletedDate); //删除日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserLogEN.mId); 
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("UserLog_Delete", values);
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
//删除UserLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserLog where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
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
//删除UserLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserLog where mId in (" + strKeyList + ")";
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
//删除UserLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserLog where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:根据标志删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySign)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecordBySign(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
//删除UserLog本表中与当前对象有关的记录
strSQL = strSQL + string.Format("Update UserLog Set {0}='1', {1} = '{2}' where mId = {3}",
conUserLog.IsDeleted, conUserLog.DeletedDate, clsDateTime.getTodayDateTimeStr(0), lngmId);
 return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:恢复被删除的记录,针对有删除标志的表
 /// (AutoGCLib.DALCode4CSharp:GenUnDelRecordBySign)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回恢复删除的记录数</returns>
public int UnDelRecordBySign(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
//删除UserLog本表中与当前对象有关的记录
strSQL = strSQL + string.Format("Update UserLog Set {0}='0', {1} = '{2}' where mId = {3}",
conUserLog.IsDeleted, conUserLog.DeletedDate, clsDateTime.getTodayDateTimeStr(0), lngmId);
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserLogDA: DelUserLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserLog where " + strCondition ;
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
public bool DelUserLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserLogDA: DelUserLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserLog where " + strCondition ;
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
 /// <param name = "objUserLogENS">源对象</param>
 /// <param name = "objUserLogENT">目标对象</param>
public void CopyTo(clsUserLogEN objUserLogENS, clsUserLogEN objUserLogENT)
{
objUserLogENT.mId = objUserLogENS.mId; //mId
objUserLogENT.UserId = objUserLogENS.UserId; //用户Id
objUserLogENT.LoginTime = objUserLogENS.LoginTime; //登陆时间
objUserLogENT.LoginDate = objUserLogENS.LoginDate; //登陆日期
objUserLogENT.UserIp = objUserLogENS.UserIp; //用户IP
objUserLogENT.ObjectTable = objUserLogENS.ObjectTable; //对象表
objUserLogENT.UsedValue = objUserLogENS.UsedValue; //使用值
objUserLogENT.UpdDate = objUserLogENS.UpdDate; //修改日期
objUserLogENT.Memo = objUserLogENS.Memo; //说明
objUserLogENT.IsDeleted = objUserLogENS.IsDeleted; //是否删除
objUserLogENT.OrderNum = objUserLogENS.OrderNum; //序号
objUserLogENT.DeletedDate = objUserLogENS.DeletedDate; //删除日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserLogEN objUserLogEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserLogEN.OrderNum, conUserLog.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserLogEN.UserId, 18, conUserLog.UserId);
clsCheckSql.CheckFieldLen(objUserLogEN.LoginTime, 6, conUserLog.LoginTime);
clsCheckSql.CheckFieldLen(objUserLogEN.LoginDate, 8, conUserLog.LoginDate);
clsCheckSql.CheckFieldLen(objUserLogEN.UserIp, 40, conUserLog.UserIp);
clsCheckSql.CheckFieldLen(objUserLogEN.ObjectTable, 50, conUserLog.ObjectTable);
clsCheckSql.CheckFieldLen(objUserLogEN.UsedValue, 50, conUserLog.UsedValue);
clsCheckSql.CheckFieldLen(objUserLogEN.UpdDate, 20, conUserLog.UpdDate);
clsCheckSql.CheckFieldLen(objUserLogEN.Memo, 1000, conUserLog.Memo);
clsCheckSql.CheckFieldLen(objUserLogEN.DeletedDate, 50, conUserLog.DeletedDate);
//检查字段外键固定长度
 objUserLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserLogEN objUserLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserLogEN.UserId, 18, conUserLog.UserId);
clsCheckSql.CheckFieldLen(objUserLogEN.LoginTime, 6, conUserLog.LoginTime);
clsCheckSql.CheckFieldLen(objUserLogEN.LoginDate, 8, conUserLog.LoginDate);
clsCheckSql.CheckFieldLen(objUserLogEN.UserIp, 40, conUserLog.UserIp);
clsCheckSql.CheckFieldLen(objUserLogEN.ObjectTable, 50, conUserLog.ObjectTable);
clsCheckSql.CheckFieldLen(objUserLogEN.UsedValue, 50, conUserLog.UsedValue);
clsCheckSql.CheckFieldLen(objUserLogEN.UpdDate, 20, conUserLog.UpdDate);
clsCheckSql.CheckFieldLen(objUserLogEN.Memo, 1000, conUserLog.Memo);
clsCheckSql.CheckFieldLen(objUserLogEN.DeletedDate, 50, conUserLog.DeletedDate);
//检查外键字段长度
 objUserLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserLogEN objUserLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserLogEN.UserId, 18, conUserLog.UserId);
clsCheckSql.CheckFieldLen(objUserLogEN.LoginTime, 6, conUserLog.LoginTime);
clsCheckSql.CheckFieldLen(objUserLogEN.LoginDate, 8, conUserLog.LoginDate);
clsCheckSql.CheckFieldLen(objUserLogEN.UserIp, 40, conUserLog.UserIp);
clsCheckSql.CheckFieldLen(objUserLogEN.ObjectTable, 50, conUserLog.ObjectTable);
clsCheckSql.CheckFieldLen(objUserLogEN.UsedValue, 50, conUserLog.UsedValue);
clsCheckSql.CheckFieldLen(objUserLogEN.UpdDate, 20, conUserLog.UpdDate);
clsCheckSql.CheckFieldLen(objUserLogEN.Memo, 1000, conUserLog.Memo);
clsCheckSql.CheckFieldLen(objUserLogEN.DeletedDate, 50, conUserLog.DeletedDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.UserId, conUserLog.UserId);
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.LoginTime, conUserLog.LoginTime);
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.LoginDate, conUserLog.LoginDate);
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.UserIp, conUserLog.UserIp);
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.ObjectTable, conUserLog.ObjectTable);
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.UsedValue, conUserLog.UsedValue);
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.UpdDate, conUserLog.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.Memo, conUserLog.Memo);
clsCheckSql.CheckSqlInjection4Field(objUserLogEN.DeletedDate, conUserLog.DeletedDate);
//检查外键字段长度
 objUserLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetmId()
{
//获取某学院所有专业信息
string strSQL = "select mId, UserId from UserLog ";
 clsSpecSQLforSql mySql = clsUserLogDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UserLog(用户日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUserLogEN objUserLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objUserLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserLogEN.UserId);
}
 if (objUserLogEN.ObjectTable == null)
{
 sbCondition.AppendFormat(" and ObjectTable is null");
}
else
{
 sbCondition.AppendFormat(" and ObjectTable = '{0}'", objUserLogEN.ObjectTable);
}
 if (objUserLogEN.LoginDate == null)
{
 sbCondition.AppendFormat(" and LoginDate is null");
}
else
{
 sbCondition.AppendFormat(" and LoginDate = '{0}'", objUserLogEN.LoginDate);
}
 if (objUserLogEN.LoginTime == null)
{
 sbCondition.AppendFormat(" and LoginTime is null");
}
else
{
 sbCondition.AppendFormat(" and LoginTime = '{0}'", objUserLogEN.LoginTime);
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserLogEN._CurrTabName);
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserLogEN._CurrTabName, strCondition);
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
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
 objSQL = clsUserLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}