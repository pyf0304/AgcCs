
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSysLogDA
 表名:SysLog(00050129)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:43
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
 /// 系统日志(SysLog)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSysLogDA : clsCommBase4DA
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
 return clsSysLogEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSysLogEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSysLogEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSysLogEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSysLogEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SysLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSysLogDA: GetDataTable_SysLog)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSysLogDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSysLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysLog where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysLog where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSysLogDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SysLog where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSysLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SysLog.* " + 
$"from SysLog " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SysLog.mId not in " + 
$"(Select top {intTop_In} SysLog.mId from SysLog " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysLog where {1} and mId not in (Select top {2} mId from SysLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysLog where {1} and mId not in (Select top {3} mId from SysLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSysLogDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SysLog.* " + 
$"from SysLog " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SysLog.mId not in " + 
$"(Select top {intTop_In} SysLog.mId from SysLog " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SysLog where {1} and mId not in (Select top {2} mId from SysLog where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SysLog where {1} and mId not in (Select top {3} mId from SysLog where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSysLogEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSysLogDA:GetObjLst)", objException.Message));
}
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = TransNullToInt(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysLogDA: GetObjLst)", objException.Message));
}
objSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysLogEN);
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
public List<clsSysLogEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSysLogDA:GetObjLstByTabName)", objException.Message));
}
List<clsSysLogEN> arrObjLst = new List<clsSysLogEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = TransNullToInt(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSysLogDA: GetObjLst)", objException.Message));
}
objSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSysLogEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSysLog(ref clsSysLogEN objSysLogEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where mId = " + ""+ objSysLogEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSysLogEN.mId = TransNullToInt(objDT.Rows[0][conSysLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objSysLogEN.LoginTime = objDT.Rows[0][conSysLog.LoginTime].ToString().Trim(); //登陆时间(字段类型:varchar,字段长度:6,是否可空:True)
 objSysLogEN.LoginDate = objDT.Rows[0][conSysLog.LoginDate].ToString().Trim(); //登陆日期(字段类型:varchar,字段长度:8,是否可空:True)
 objSysLogEN.TableName = objDT.Rows[0][conSysLog.TableName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objSysLogEN.TableKey = objDT.Rows[0][conSysLog.TableKey].ToString().Trim(); //数据表关键字值(字段类型:varchar,字段长度:100,是否可空:True)
 objSysLogEN.UserIp = objDT.Rows[0][conSysLog.UserIp].ToString().Trim(); //用户IP(字段类型:varchar,字段长度:40,是否可空:True)
 objSysLogEN.OpTypeId = objDT.Rows[0][conSysLog.OpTypeId].ToString().Trim(); //操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objSysLogEN.OpContent = objDT.Rows[0][conSysLog.OpContent].ToString().Trim(); //操作内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objSysLogEN.OpDate = objDT.Rows[0][conSysLog.OpDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:8,是否可空:True)
 objSysLogEN.OpTime = objDT.Rows[0][conSysLog.OpTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:6,是否可空:True)
 objSysLogEN.PrjId = objDT.Rows[0][conSysLog.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSysLogEN.UserId = objDT.Rows[0][conSysLog.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objSysLogEN.Memo = objDT.Rows[0][conSysLog.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSysLogDA: GetSysLog)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsSysLogEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
 objSysLogEN.mId = Int32.Parse(objRow[conSysLog.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间(字段类型:varchar,字段长度:6,是否可空:True)
 objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期(字段类型:varchar,字段长度:8,是否可空:True)
 objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:True)
 objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值(字段类型:varchar,字段长度:100,是否可空:True)
 objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP(字段类型:varchar,字段长度:40,是否可空:True)
 objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id(字段类型:char,字段长度:4,是否可空:False)
 objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:8,是否可空:True)
 objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:6,是否可空:True)
 objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSysLogDA: GetObjBymId)", objException.Message));
}
return objSysLogEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSysLogEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSysLogDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSysLogEN objSysLogEN = new clsSysLogEN()
{
mId = TransNullToInt(objRow[conSysLog.mId].ToString().Trim()), //mId
LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(), //登陆时间
LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(), //登陆日期
TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(), //表名
TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(), //数据表关键字值
UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(), //用户IP
OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(), //操作类型Id
OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(), //操作内容
OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(), //操作日期
OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(), //操作时间
PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(), //工程Id
UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(), //用户Id
Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim() //说明
};
objSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysLogEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSysLogDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSysLogEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = TransNullToInt(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSysLogDA: GetObjByDataRowSysLog)", objException.Message));
}
objSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysLogEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSysLogEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSysLogEN objSysLogEN = new clsSysLogEN();
try
{
objSysLogEN.mId = TransNullToInt(objRow[conSysLog.mId].ToString().Trim()); //mId
objSysLogEN.LoginTime = objRow[conSysLog.LoginTime] == DBNull.Value ? null : objRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objSysLogEN.LoginDate = objRow[conSysLog.LoginDate] == DBNull.Value ? null : objRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objSysLogEN.TableName = objRow[conSysLog.TableName] == DBNull.Value ? null : objRow[conSysLog.TableName].ToString().Trim(); //表名
objSysLogEN.TableKey = objRow[conSysLog.TableKey] == DBNull.Value ? null : objRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objSysLogEN.UserIp = objRow[conSysLog.UserIp] == DBNull.Value ? null : objRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objSysLogEN.OpTypeId = objRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objSysLogEN.OpContent = objRow[conSysLog.OpContent] == DBNull.Value ? null : objRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objSysLogEN.OpDate = objRow[conSysLog.OpDate] == DBNull.Value ? null : objRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objSysLogEN.OpTime = objRow[conSysLog.OpTime] == DBNull.Value ? null : objRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objSysLogEN.PrjId = objRow[conSysLog.PrjId] == DBNull.Value ? null : objRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objSysLogEN.UserId = objRow[conSysLog.UserId] == DBNull.Value ? null : objRow[conSysLog.UserId].ToString().Trim(); //用户Id
objSysLogEN.Memo = objRow[conSysLog.Memo] == DBNull.Value ? null : objRow[conSysLog.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSysLogDA: GetObjByDataRow)", objException.Message));
}
objSysLogEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSysLogEN;
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
objSQL = clsSysLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysLogEN._CurrTabName, conSysLog.mId, 8, "");
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
objSQL = clsSysLogDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSysLogEN._CurrTabName, conSysLog.mId, 8, strPrefix);
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from SysLog where " + strCondition;
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from SysLog where " + strCondition;
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysLog", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSysLogDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SysLog", strCondition))
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
objSQL = clsSysLogDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SysLog");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSysLogEN objSysLogEN)
 {
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysLogEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysLog");
objRow = objDS.Tables["SysLog"].NewRow();
 if (objSysLogEN.LoginTime !=  "")
 {
objRow[conSysLog.LoginTime] = objSysLogEN.LoginTime; //登陆时间
 }
 if (objSysLogEN.LoginDate !=  "")
 {
objRow[conSysLog.LoginDate] = objSysLogEN.LoginDate; //登陆日期
 }
 if (objSysLogEN.TableName !=  "")
 {
objRow[conSysLog.TableName] = objSysLogEN.TableName; //表名
 }
 if (objSysLogEN.TableKey !=  "")
 {
objRow[conSysLog.TableKey] = objSysLogEN.TableKey; //数据表关键字值
 }
 if (objSysLogEN.UserIp !=  "")
 {
objRow[conSysLog.UserIp] = objSysLogEN.UserIp; //用户IP
 }
objRow[conSysLog.OpTypeId] = objSysLogEN.OpTypeId; //操作类型Id
 if (objSysLogEN.OpContent !=  "")
 {
objRow[conSysLog.OpContent] = objSysLogEN.OpContent; //操作内容
 }
 if (objSysLogEN.OpDate !=  "")
 {
objRow[conSysLog.OpDate] = objSysLogEN.OpDate; //操作日期
 }
 if (objSysLogEN.OpTime !=  "")
 {
objRow[conSysLog.OpTime] = objSysLogEN.OpTime; //操作时间
 }
 if (objSysLogEN.PrjId !=  "")
 {
objRow[conSysLog.PrjId] = objSysLogEN.PrjId; //工程Id
 }
 if (objSysLogEN.UserId !=  "")
 {
objRow[conSysLog.UserId] = objSysLogEN.UserId; //用户Id
 }
 if (objSysLogEN.Memo !=  "")
 {
objRow[conSysLog.Memo] = objSysLogEN.Memo; //说明
 }
objDS.Tables[clsSysLogEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSysLogEN._CurrTabName);
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysLogEN objSysLogEN)
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.LoginTime);
 var strLoginTime = objSysLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objSysLogEN.LoginDate !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.LoginDate);
 var strLoginDate = objSysLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginDate + "'");
 }
 
 if (objSysLogEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.TableName);
 var strTableName = objSysLogEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objSysLogEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.TableKey);
 var strTableKey = objSysLogEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysLogEN.UserIp !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.UserIp);
 var strUserIp = objSysLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserIp + "'");
 }
 
 if (objSysLogEN.OpTypeId  ==  "")
 {
 objSysLogEN.OpTypeId = null;
 }
 if (objSysLogEN.OpTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpTypeId);
 var strOpTypeId = objSysLogEN.OpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpTypeId + "'");
 }
 
 if (objSysLogEN.OpContent !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpContent);
 var strOpContent = objSysLogEN.OpContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpContent + "'");
 }
 
 if (objSysLogEN.OpDate !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpDate);
 var strOpDate = objSysLogEN.OpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpDate + "'");
 }
 
 if (objSysLogEN.OpTime !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpTime);
 var strOpTime = objSysLogEN.OpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpTime + "'");
 }
 
 if (objSysLogEN.PrjId  ==  "")
 {
 objSysLogEN.PrjId = null;
 }
 if (objSysLogEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.PrjId);
 var strPrjId = objSysLogEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSysLogEN.UserId  ==  "")
 {
 objSysLogEN.UserId = null;
 }
 if (objSysLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.UserId);
 var strUserId = objSysLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSysLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.Memo);
 var strMemo = objSysLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysLogEN objSysLogEN)
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.LoginTime);
 var strLoginTime = objSysLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objSysLogEN.LoginDate !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.LoginDate);
 var strLoginDate = objSysLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginDate + "'");
 }
 
 if (objSysLogEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.TableName);
 var strTableName = objSysLogEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objSysLogEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.TableKey);
 var strTableKey = objSysLogEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysLogEN.UserIp !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.UserIp);
 var strUserIp = objSysLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserIp + "'");
 }
 
 if (objSysLogEN.OpTypeId  ==  "")
 {
 objSysLogEN.OpTypeId = null;
 }
 if (objSysLogEN.OpTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpTypeId);
 var strOpTypeId = objSysLogEN.OpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpTypeId + "'");
 }
 
 if (objSysLogEN.OpContent !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpContent);
 var strOpContent = objSysLogEN.OpContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpContent + "'");
 }
 
 if (objSysLogEN.OpDate !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpDate);
 var strOpDate = objSysLogEN.OpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpDate + "'");
 }
 
 if (objSysLogEN.OpTime !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpTime);
 var strOpTime = objSysLogEN.OpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpTime + "'");
 }
 
 if (objSysLogEN.PrjId  ==  "")
 {
 objSysLogEN.PrjId = null;
 }
 if (objSysLogEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.PrjId);
 var strPrjId = objSysLogEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSysLogEN.UserId  ==  "")
 {
 objSysLogEN.UserId = null;
 }
 if (objSysLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.UserId);
 var strUserId = objSysLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSysLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.Memo);
 var strMemo = objSysLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSysLogEN objSysLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysLogEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.LoginTime);
 var strLoginTime = objSysLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objSysLogEN.LoginDate !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.LoginDate);
 var strLoginDate = objSysLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginDate + "'");
 }
 
 if (objSysLogEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.TableName);
 var strTableName = objSysLogEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objSysLogEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.TableKey);
 var strTableKey = objSysLogEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysLogEN.UserIp !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.UserIp);
 var strUserIp = objSysLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserIp + "'");
 }
 
 if (objSysLogEN.OpTypeId  ==  "")
 {
 objSysLogEN.OpTypeId = null;
 }
 if (objSysLogEN.OpTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpTypeId);
 var strOpTypeId = objSysLogEN.OpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpTypeId + "'");
 }
 
 if (objSysLogEN.OpContent !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpContent);
 var strOpContent = objSysLogEN.OpContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpContent + "'");
 }
 
 if (objSysLogEN.OpDate !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpDate);
 var strOpDate = objSysLogEN.OpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpDate + "'");
 }
 
 if (objSysLogEN.OpTime !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpTime);
 var strOpTime = objSysLogEN.OpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpTime + "'");
 }
 
 if (objSysLogEN.PrjId  ==  "")
 {
 objSysLogEN.PrjId = null;
 }
 if (objSysLogEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.PrjId);
 var strPrjId = objSysLogEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSysLogEN.UserId  ==  "")
 {
 objSysLogEN.UserId = null;
 }
 if (objSysLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.UserId);
 var strUserId = objSysLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSysLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.Memo);
 var strMemo = objSysLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysLog");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSysLogEN objSysLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSysLogEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSysLogEN.LoginTime !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.LoginTime);
 var strLoginTime = objSysLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginTime + "'");
 }
 
 if (objSysLogEN.LoginDate !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.LoginDate);
 var strLoginDate = objSysLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLoginDate + "'");
 }
 
 if (objSysLogEN.TableName !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.TableName);
 var strTableName = objSysLogEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableName + "'");
 }
 
 if (objSysLogEN.TableKey !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.TableKey);
 var strTableKey = objSysLogEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableKey + "'");
 }
 
 if (objSysLogEN.UserIp !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.UserIp);
 var strUserIp = objSysLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserIp + "'");
 }
 
 if (objSysLogEN.OpTypeId  ==  "")
 {
 objSysLogEN.OpTypeId = null;
 }
 if (objSysLogEN.OpTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpTypeId);
 var strOpTypeId = objSysLogEN.OpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpTypeId + "'");
 }
 
 if (objSysLogEN.OpContent !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpContent);
 var strOpContent = objSysLogEN.OpContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpContent + "'");
 }
 
 if (objSysLogEN.OpDate !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpDate);
 var strOpDate = objSysLogEN.OpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpDate + "'");
 }
 
 if (objSysLogEN.OpTime !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.OpTime);
 var strOpTime = objSysLogEN.OpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpTime + "'");
 }
 
 if (objSysLogEN.PrjId  ==  "")
 {
 objSysLogEN.PrjId = null;
 }
 if (objSysLogEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.PrjId);
 var strPrjId = objSysLogEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSysLogEN.UserId  ==  "")
 {
 objSysLogEN.UserId = null;
 }
 if (objSysLogEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.UserId);
 var strUserId = objSysLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objSysLogEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSysLog.Memo);
 var strMemo = objSysLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SysLog");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSysLogs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SysLog");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conSysLog.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSysLogEN._CurrTabName ].NewRow();
objRow[conSysLog.LoginTime] = oRow[conSysLog.LoginTime].ToString().Trim(); //登陆时间
objRow[conSysLog.LoginDate] = oRow[conSysLog.LoginDate].ToString().Trim(); //登陆日期
objRow[conSysLog.TableName] = oRow[conSysLog.TableName].ToString().Trim(); //表名
objRow[conSysLog.TableKey] = oRow[conSysLog.TableKey].ToString().Trim(); //数据表关键字值
objRow[conSysLog.UserIp] = oRow[conSysLog.UserIp].ToString().Trim(); //用户IP
objRow[conSysLog.OpTypeId] = oRow[conSysLog.OpTypeId].ToString().Trim(); //操作类型Id
objRow[conSysLog.OpContent] = oRow[conSysLog.OpContent].ToString().Trim(); //操作内容
objRow[conSysLog.OpDate] = oRow[conSysLog.OpDate].ToString().Trim(); //操作日期
objRow[conSysLog.OpTime] = oRow[conSysLog.OpTime].ToString().Trim(); //操作时间
objRow[conSysLog.PrjId] = oRow[conSysLog.PrjId].ToString().Trim(); //工程Id
objRow[conSysLog.UserId] = oRow[conSysLog.UserId].ToString().Trim(); //用户Id
objRow[conSysLog.Memo] = oRow[conSysLog.Memo].ToString().Trim(); //说明
 objDS.Tables[clsSysLogEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSysLogEN._CurrTabName);
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
 /// <param name = "objSysLogEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSysLogEN objSysLogEN)
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysLogEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
strSQL = "Select * from SysLog where mId = " + ""+ objSysLogEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSysLogEN._CurrTabName);
if (objDS.Tables[clsSysLogEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objSysLogEN.mId+"");
return false;
}
objRow = objDS.Tables[clsSysLogEN._CurrTabName].Rows[0];
 if (objSysLogEN.IsUpdated(conSysLog.LoginTime))
 {
objRow[conSysLog.LoginTime] = objSysLogEN.LoginTime; //登陆时间
 }
 if (objSysLogEN.IsUpdated(conSysLog.LoginDate))
 {
objRow[conSysLog.LoginDate] = objSysLogEN.LoginDate; //登陆日期
 }
 if (objSysLogEN.IsUpdated(conSysLog.TableName))
 {
objRow[conSysLog.TableName] = objSysLogEN.TableName; //表名
 }
 if (objSysLogEN.IsUpdated(conSysLog.TableKey))
 {
objRow[conSysLog.TableKey] = objSysLogEN.TableKey; //数据表关键字值
 }
 if (objSysLogEN.IsUpdated(conSysLog.UserIp))
 {
objRow[conSysLog.UserIp] = objSysLogEN.UserIp; //用户IP
 }
 if (objSysLogEN.IsUpdated(conSysLog.OpTypeId))
 {
objRow[conSysLog.OpTypeId] = objSysLogEN.OpTypeId; //操作类型Id
 }
 if (objSysLogEN.IsUpdated(conSysLog.OpContent))
 {
objRow[conSysLog.OpContent] = objSysLogEN.OpContent; //操作内容
 }
 if (objSysLogEN.IsUpdated(conSysLog.OpDate))
 {
objRow[conSysLog.OpDate] = objSysLogEN.OpDate; //操作日期
 }
 if (objSysLogEN.IsUpdated(conSysLog.OpTime))
 {
objRow[conSysLog.OpTime] = objSysLogEN.OpTime; //操作时间
 }
 if (objSysLogEN.IsUpdated(conSysLog.PrjId))
 {
objRow[conSysLog.PrjId] = objSysLogEN.PrjId; //工程Id
 }
 if (objSysLogEN.IsUpdated(conSysLog.UserId))
 {
objRow[conSysLog.UserId] = objSysLogEN.UserId; //用户Id
 }
 if (objSysLogEN.IsUpdated(conSysLog.Memo))
 {
objRow[conSysLog.Memo] = objSysLogEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsSysLogEN._CurrTabName);
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysLogEN objSysLogEN)
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SysLog Set ");
 
 if (objSysLogEN.IsUpdated(conSysLog.LoginTime))
 {
 if (objSysLogEN.LoginTime !=  null)
 {
 var strLoginTime = objSysLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginTime, conSysLog.LoginTime); //登陆时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.LoginTime); //登陆时间
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.LoginDate))
 {
 if (objSysLogEN.LoginDate !=  null)
 {
 var strLoginDate = objSysLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginDate, conSysLog.LoginDate); //登陆日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.LoginDate); //登陆日期
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.TableName))
 {
 if (objSysLogEN.TableName !=  null)
 {
 var strTableName = objSysLogEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableName, conSysLog.TableName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.TableName); //表名
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.TableKey))
 {
 if (objSysLogEN.TableKey !=  null)
 {
 var strTableKey = objSysLogEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conSysLog.TableKey); //数据表关键字值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.TableKey); //数据表关键字值
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.UserIp))
 {
 if (objSysLogEN.UserIp !=  null)
 {
 var strUserIp = objSysLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserIp, conSysLog.UserIp); //用户IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.UserIp); //用户IP
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpTypeId))
 {
 if (objSysLogEN.OpTypeId  ==  "")
 {
 objSysLogEN.OpTypeId = null;
 }
 if (objSysLogEN.OpTypeId !=  null)
 {
 var strOpTypeId = objSysLogEN.OpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpTypeId, conSysLog.OpTypeId); //操作类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.OpTypeId); //操作类型Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpContent))
 {
 if (objSysLogEN.OpContent !=  null)
 {
 var strOpContent = objSysLogEN.OpContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpContent, conSysLog.OpContent); //操作内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.OpContent); //操作内容
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpDate))
 {
 if (objSysLogEN.OpDate !=  null)
 {
 var strOpDate = objSysLogEN.OpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpDate, conSysLog.OpDate); //操作日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.OpDate); //操作日期
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpTime))
 {
 if (objSysLogEN.OpTime !=  null)
 {
 var strOpTime = objSysLogEN.OpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpTime, conSysLog.OpTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.OpTime); //操作时间
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.PrjId))
 {
 if (objSysLogEN.PrjId  ==  "")
 {
 objSysLogEN.PrjId = null;
 }
 if (objSysLogEN.PrjId !=  null)
 {
 var strPrjId = objSysLogEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSysLog.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.PrjId); //工程Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.UserId))
 {
 if (objSysLogEN.UserId  ==  "")
 {
 objSysLogEN.UserId = null;
 }
 if (objSysLogEN.UserId !=  null)
 {
 var strUserId = objSysLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conSysLog.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.UserId); //用户Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.Memo))
 {
 if (objSysLogEN.Memo !=  null)
 {
 var strMemo = objSysLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysLog.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objSysLogEN.mId); 
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
 /// <param name = "objSysLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSysLogEN objSysLogEN, string strCondition)
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysLog Set ");
 
 if (objSysLogEN.IsUpdated(conSysLog.LoginTime))
 {
 if (objSysLogEN.LoginTime !=  null)
 {
 var strLoginTime = objSysLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginTime = '{0}',", strLoginTime); //登陆时间
 }
 else
 {
 sbSQL.Append(" LoginTime = null,"); //登陆时间
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.LoginDate))
 {
 if (objSysLogEN.LoginDate !=  null)
 {
 var strLoginDate = objSysLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginDate = '{0}',", strLoginDate); //登陆日期
 }
 else
 {
 sbSQL.Append(" LoginDate = null,"); //登陆日期
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.TableName))
 {
 if (objSysLogEN.TableName !=  null)
 {
 var strTableName = objSysLogEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableName = '{0}',", strTableName); //表名
 }
 else
 {
 sbSQL.Append(" TableName = null,"); //表名
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.TableKey))
 {
 if (objSysLogEN.TableKey !=  null)
 {
 var strTableKey = objSysLogEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //数据表关键字值
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //数据表关键字值
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.UserIp))
 {
 if (objSysLogEN.UserIp !=  null)
 {
 var strUserIp = objSysLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserIp = '{0}',", strUserIp); //用户IP
 }
 else
 {
 sbSQL.Append(" UserIp = null,"); //用户IP
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpTypeId))
 {
 if (objSysLogEN.OpTypeId  ==  "")
 {
 objSysLogEN.OpTypeId = null;
 }
 if (objSysLogEN.OpTypeId !=  null)
 {
 var strOpTypeId = objSysLogEN.OpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpTypeId = '{0}',", strOpTypeId); //操作类型Id
 }
 else
 {
 sbSQL.Append(" OpTypeId = null,"); //操作类型Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpContent))
 {
 if (objSysLogEN.OpContent !=  null)
 {
 var strOpContent = objSysLogEN.OpContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpContent = '{0}',", strOpContent); //操作内容
 }
 else
 {
 sbSQL.Append(" OpContent = null,"); //操作内容
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpDate))
 {
 if (objSysLogEN.OpDate !=  null)
 {
 var strOpDate = objSysLogEN.OpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpDate = '{0}',", strOpDate); //操作日期
 }
 else
 {
 sbSQL.Append(" OpDate = null,"); //操作日期
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpTime))
 {
 if (objSysLogEN.OpTime !=  null)
 {
 var strOpTime = objSysLogEN.OpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpTime = '{0}',", strOpTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OpTime = null,"); //操作时间
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.PrjId))
 {
 if (objSysLogEN.PrjId  ==  "")
 {
 objSysLogEN.PrjId = null;
 }
 if (objSysLogEN.PrjId !=  null)
 {
 var strPrjId = objSysLogEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.UserId))
 {
 if (objSysLogEN.UserId  ==  "")
 {
 objSysLogEN.UserId = null;
 }
 if (objSysLogEN.UserId !=  null)
 {
 var strUserId = objSysLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.Memo))
 {
 if (objSysLogEN.Memo !=  null)
 {
 var strMemo = objSysLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSysLogEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSysLogEN objSysLogEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysLog Set ");
 
 if (objSysLogEN.IsUpdated(conSysLog.LoginTime))
 {
 if (objSysLogEN.LoginTime !=  null)
 {
 var strLoginTime = objSysLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginTime = '{0}',", strLoginTime); //登陆时间
 }
 else
 {
 sbSQL.Append(" LoginTime = null,"); //登陆时间
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.LoginDate))
 {
 if (objSysLogEN.LoginDate !=  null)
 {
 var strLoginDate = objSysLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LoginDate = '{0}',", strLoginDate); //登陆日期
 }
 else
 {
 sbSQL.Append(" LoginDate = null,"); //登陆日期
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.TableName))
 {
 if (objSysLogEN.TableName !=  null)
 {
 var strTableName = objSysLogEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableName = '{0}',", strTableName); //表名
 }
 else
 {
 sbSQL.Append(" TableName = null,"); //表名
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.TableKey))
 {
 if (objSysLogEN.TableKey !=  null)
 {
 var strTableKey = objSysLogEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableKey = '{0}',", strTableKey); //数据表关键字值
 }
 else
 {
 sbSQL.Append(" TableKey = null,"); //数据表关键字值
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.UserIp))
 {
 if (objSysLogEN.UserIp !=  null)
 {
 var strUserIp = objSysLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserIp = '{0}',", strUserIp); //用户IP
 }
 else
 {
 sbSQL.Append(" UserIp = null,"); //用户IP
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpTypeId))
 {
 if (objSysLogEN.OpTypeId  ==  "")
 {
 objSysLogEN.OpTypeId = null;
 }
 if (objSysLogEN.OpTypeId !=  null)
 {
 var strOpTypeId = objSysLogEN.OpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpTypeId = '{0}',", strOpTypeId); //操作类型Id
 }
 else
 {
 sbSQL.Append(" OpTypeId = null,"); //操作类型Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpContent))
 {
 if (objSysLogEN.OpContent !=  null)
 {
 var strOpContent = objSysLogEN.OpContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpContent = '{0}',", strOpContent); //操作内容
 }
 else
 {
 sbSQL.Append(" OpContent = null,"); //操作内容
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpDate))
 {
 if (objSysLogEN.OpDate !=  null)
 {
 var strOpDate = objSysLogEN.OpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpDate = '{0}',", strOpDate); //操作日期
 }
 else
 {
 sbSQL.Append(" OpDate = null,"); //操作日期
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpTime))
 {
 if (objSysLogEN.OpTime !=  null)
 {
 var strOpTime = objSysLogEN.OpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpTime = '{0}',", strOpTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OpTime = null,"); //操作时间
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.PrjId))
 {
 if (objSysLogEN.PrjId  ==  "")
 {
 objSysLogEN.PrjId = null;
 }
 if (objSysLogEN.PrjId !=  null)
 {
 var strPrjId = objSysLogEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.UserId))
 {
 if (objSysLogEN.UserId  ==  "")
 {
 objSysLogEN.UserId = null;
 }
 if (objSysLogEN.UserId !=  null)
 {
 var strUserId = objSysLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.Memo))
 {
 if (objSysLogEN.Memo !=  null)
 {
 var strMemo = objSysLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSysLogEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSysLogEN objSysLogEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSysLogEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSysLogEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SysLog Set ");
 
 if (objSysLogEN.IsUpdated(conSysLog.LoginTime))
 {
 if (objSysLogEN.LoginTime !=  null)
 {
 var strLoginTime = objSysLogEN.LoginTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginTime, conSysLog.LoginTime); //登陆时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.LoginTime); //登陆时间
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.LoginDate))
 {
 if (objSysLogEN.LoginDate !=  null)
 {
 var strLoginDate = objSysLogEN.LoginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLoginDate, conSysLog.LoginDate); //登陆日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.LoginDate); //登陆日期
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.TableName))
 {
 if (objSysLogEN.TableName !=  null)
 {
 var strTableName = objSysLogEN.TableName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableName, conSysLog.TableName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.TableName); //表名
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.TableKey))
 {
 if (objSysLogEN.TableKey !=  null)
 {
 var strTableKey = objSysLogEN.TableKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableKey, conSysLog.TableKey); //数据表关键字值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.TableKey); //数据表关键字值
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.UserIp))
 {
 if (objSysLogEN.UserIp !=  null)
 {
 var strUserIp = objSysLogEN.UserIp.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserIp, conSysLog.UserIp); //用户IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.UserIp); //用户IP
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpTypeId))
 {
 if (objSysLogEN.OpTypeId  ==  "")
 {
 objSysLogEN.OpTypeId = null;
 }
 if (objSysLogEN.OpTypeId !=  null)
 {
 var strOpTypeId = objSysLogEN.OpTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpTypeId, conSysLog.OpTypeId); //操作类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.OpTypeId); //操作类型Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpContent))
 {
 if (objSysLogEN.OpContent !=  null)
 {
 var strOpContent = objSysLogEN.OpContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpContent, conSysLog.OpContent); //操作内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.OpContent); //操作内容
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpDate))
 {
 if (objSysLogEN.OpDate !=  null)
 {
 var strOpDate = objSysLogEN.OpDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpDate, conSysLog.OpDate); //操作日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.OpDate); //操作日期
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.OpTime))
 {
 if (objSysLogEN.OpTime !=  null)
 {
 var strOpTime = objSysLogEN.OpTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpTime, conSysLog.OpTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.OpTime); //操作时间
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.PrjId))
 {
 if (objSysLogEN.PrjId  ==  "")
 {
 objSysLogEN.PrjId = null;
 }
 if (objSysLogEN.PrjId !=  null)
 {
 var strPrjId = objSysLogEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSysLog.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.PrjId); //工程Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.UserId))
 {
 if (objSysLogEN.UserId  ==  "")
 {
 objSysLogEN.UserId = null;
 }
 if (objSysLogEN.UserId !=  null)
 {
 var strUserId = objSysLogEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conSysLog.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.UserId); //用户Id
 }
 }
 
 if (objSysLogEN.IsUpdated(conSysLog.Memo))
 {
 if (objSysLogEN.Memo !=  null)
 {
 var strMemo = objSysLogEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSysLog.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSysLog.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objSysLogEN.mId); 
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("SysLog_Delete", values);
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
//删除SysLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysLog where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSysLog(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
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
//删除SysLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysLog where mId in (" + strKeyList + ")";
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
//删除SysLog本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SysLog where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSysLog(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSysLogDA: DelSysLog)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysLog where " + strCondition ;
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
public bool DelSysLogWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSysLogDA: DelSysLogWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSysLogDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SysLog where " + strCondition ;
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
 /// <param name = "objSysLogENS">源对象</param>
 /// <param name = "objSysLogENT">目标对象</param>
public void CopyTo(clsSysLogEN objSysLogENS, clsSysLogEN objSysLogENT)
{
objSysLogENT.mId = objSysLogENS.mId; //mId
objSysLogENT.LoginTime = objSysLogENS.LoginTime; //登陆时间
objSysLogENT.LoginDate = objSysLogENS.LoginDate; //登陆日期
objSysLogENT.TableName = objSysLogENS.TableName; //表名
objSysLogENT.TableKey = objSysLogENS.TableKey; //数据表关键字值
objSysLogENT.UserIp = objSysLogENS.UserIp; //用户IP
objSysLogENT.OpTypeId = objSysLogENS.OpTypeId; //操作类型Id
objSysLogENT.OpContent = objSysLogENS.OpContent; //操作内容
objSysLogENT.OpDate = objSysLogENS.OpDate; //操作日期
objSysLogENT.OpTime = objSysLogENS.OpTime; //操作时间
objSysLogENT.PrjId = objSysLogENS.PrjId; //工程Id
objSysLogENT.UserId = objSysLogENS.UserId; //用户Id
objSysLogENT.Memo = objSysLogENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSysLogEN objSysLogEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSysLogEN.OpTypeId, conSysLog.OpTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSysLogEN.LoginTime, 6, conSysLog.LoginTime);
clsCheckSql.CheckFieldLen(objSysLogEN.LoginDate, 8, conSysLog.LoginDate);
clsCheckSql.CheckFieldLen(objSysLogEN.TableName, 100, conSysLog.TableName);
clsCheckSql.CheckFieldLen(objSysLogEN.TableKey, 100, conSysLog.TableKey);
clsCheckSql.CheckFieldLen(objSysLogEN.UserIp, 40, conSysLog.UserIp);
clsCheckSql.CheckFieldLen(objSysLogEN.OpTypeId, 4, conSysLog.OpTypeId);
clsCheckSql.CheckFieldLen(objSysLogEN.OpContent, 1000, conSysLog.OpContent);
clsCheckSql.CheckFieldLen(objSysLogEN.OpDate, 8, conSysLog.OpDate);
clsCheckSql.CheckFieldLen(objSysLogEN.OpTime, 6, conSysLog.OpTime);
clsCheckSql.CheckFieldLen(objSysLogEN.PrjId, 4, conSysLog.PrjId);
clsCheckSql.CheckFieldLen(objSysLogEN.UserId, 18, conSysLog.UserId);
clsCheckSql.CheckFieldLen(objSysLogEN.Memo, 1000, conSysLog.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objSysLogEN.OpTypeId, 4, conSysLog.OpTypeId);
clsCheckSql.CheckFieldForeignKey(objSysLogEN.PrjId, 4, conSysLog.PrjId);
 objSysLogEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSysLogEN objSysLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysLogEN.LoginTime, 6, conSysLog.LoginTime);
clsCheckSql.CheckFieldLen(objSysLogEN.LoginDate, 8, conSysLog.LoginDate);
clsCheckSql.CheckFieldLen(objSysLogEN.TableName, 100, conSysLog.TableName);
clsCheckSql.CheckFieldLen(objSysLogEN.TableKey, 100, conSysLog.TableKey);
clsCheckSql.CheckFieldLen(objSysLogEN.UserIp, 40, conSysLog.UserIp);
clsCheckSql.CheckFieldLen(objSysLogEN.OpTypeId, 4, conSysLog.OpTypeId);
clsCheckSql.CheckFieldLen(objSysLogEN.OpContent, 1000, conSysLog.OpContent);
clsCheckSql.CheckFieldLen(objSysLogEN.OpDate, 8, conSysLog.OpDate);
clsCheckSql.CheckFieldLen(objSysLogEN.OpTime, 6, conSysLog.OpTime);
clsCheckSql.CheckFieldLen(objSysLogEN.PrjId, 4, conSysLog.PrjId);
clsCheckSql.CheckFieldLen(objSysLogEN.UserId, 18, conSysLog.UserId);
clsCheckSql.CheckFieldLen(objSysLogEN.Memo, 1000, conSysLog.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSysLogEN.OpTypeId, 4, conSysLog.OpTypeId);
clsCheckSql.CheckFieldForeignKey(objSysLogEN.PrjId, 4, conSysLog.PrjId);
 objSysLogEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSysLogEN objSysLogEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSysLogEN.LoginTime, 6, conSysLog.LoginTime);
clsCheckSql.CheckFieldLen(objSysLogEN.LoginDate, 8, conSysLog.LoginDate);
clsCheckSql.CheckFieldLen(objSysLogEN.TableName, 100, conSysLog.TableName);
clsCheckSql.CheckFieldLen(objSysLogEN.TableKey, 100, conSysLog.TableKey);
clsCheckSql.CheckFieldLen(objSysLogEN.UserIp, 40, conSysLog.UserIp);
clsCheckSql.CheckFieldLen(objSysLogEN.OpTypeId, 4, conSysLog.OpTypeId);
clsCheckSql.CheckFieldLen(objSysLogEN.OpContent, 1000, conSysLog.OpContent);
clsCheckSql.CheckFieldLen(objSysLogEN.OpDate, 8, conSysLog.OpDate);
clsCheckSql.CheckFieldLen(objSysLogEN.OpTime, 6, conSysLog.OpTime);
clsCheckSql.CheckFieldLen(objSysLogEN.PrjId, 4, conSysLog.PrjId);
clsCheckSql.CheckFieldLen(objSysLogEN.UserId, 18, conSysLog.UserId);
clsCheckSql.CheckFieldLen(objSysLogEN.Memo, 1000, conSysLog.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.LoginTime, conSysLog.LoginTime);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.LoginDate, conSysLog.LoginDate);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.TableName, conSysLog.TableName);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.TableKey, conSysLog.TableKey);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.UserIp, conSysLog.UserIp);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.OpTypeId, conSysLog.OpTypeId);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.OpContent, conSysLog.OpContent);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.OpDate, conSysLog.OpDate);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.OpTime, conSysLog.OpTime);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.PrjId, conSysLog.PrjId);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.UserId, conSysLog.UserId);
clsCheckSql.CheckSqlInjection4Field(objSysLogEN.Memo, conSysLog.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSysLogEN.OpTypeId, 4, conSysLog.OpTypeId);
clsCheckSql.CheckFieldForeignKey(objSysLogEN.PrjId, 4, conSysLog.PrjId);
 objSysLogEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SysLog(系统日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSysLogEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSysLogEN objSysLogEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objSysLogEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objSysLogEN.UserId);
}
 if (objSysLogEN.OpDate == null)
{
 sbCondition.AppendFormat(" and OpDate is null");
}
else
{
 sbCondition.AppendFormat(" and OpDate = '{0}'", objSysLogEN.OpDate);
}
 if (objSysLogEN.OpTime == null)
{
 sbCondition.AppendFormat(" and OpTime is null");
}
else
{
 sbCondition.AppendFormat(" and OpTime = '{0}'", objSysLogEN.OpTime);
}
 if (objSysLogEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null");
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSysLogEN.PrjId);
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysLogEN._CurrTabName);
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSysLogEN._CurrTabName, strCondition);
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
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
 objSQL = clsSysLogDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}