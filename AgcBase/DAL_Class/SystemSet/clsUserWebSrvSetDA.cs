
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserWebSrvSetDA
 表名:UserWebSrvSet(00050528)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:07:53
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
 /// 用户WebSrv设置(UserWebSrvSet)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserWebSrvSetDA : clsCommBase4DA
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
 return clsUserWebSrvSetEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserWebSrvSetEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserWebSrvSetEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserWebSrvSetEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserWebSrvSetEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserWebSrvSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTable_UserWebSrvSet)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserWebSrvSet where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserWebSrvSet where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserWebSrvSet where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserWebSrvSet.* " + 
$"from UserWebSrvSet " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserWebSrvSet.mId not in " + 
$"(Select top {intTop_In} UserWebSrvSet.mId from UserWebSrvSet " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserWebSrvSet where {1} and mId not in (Select top {2} mId from UserWebSrvSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserWebSrvSet where {1} and mId not in (Select top {3} mId from UserWebSrvSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserWebSrvSet.* " + 
$"from UserWebSrvSet " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserWebSrvSet.mId not in " + 
$"(Select top {intTop_In} UserWebSrvSet.mId from UserWebSrvSet " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserWebSrvSet where {1} and mId not in (Select top {2} mId from UserWebSrvSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserWebSrvSet where {1} and mId not in (Select top {3} mId from UserWebSrvSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserWebSrvSetEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA:GetObjLst)", objException.Message));
}
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = TransNullToInt(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = TransNullToBool(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserWebSrvSetDA: GetObjLst)", objException.Message));
}
objUserWebSrvSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserWebSrvSetEN);
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
public List<clsUserWebSrvSetEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserWebSrvSetEN> arrObjLst = new List<clsUserWebSrvSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = TransNullToInt(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = TransNullToBool(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserWebSrvSetDA: GetObjLst)", objException.Message));
}
objUserWebSrvSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserWebSrvSetEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserWebSrvSet(ref clsUserWebSrvSetEN objUserWebSrvSetEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where mId = " + ""+ objUserWebSrvSetEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserWebSrvSetEN.mId = TransNullToInt(objDT.Rows[0][conUserWebSrvSet.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserWebSrvSetEN.UserId = objDT.Rows[0][conUserWebSrvSet.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserWebSrvSetEN.MachineName = objDT.Rows[0][conUserWebSrvSet.MachineName].ToString().Trim(); //机器名(字段类型:varchar,字段长度:50,是否可空:True)
 objUserWebSrvSetEN.WebApiIPAndPort = objDT.Rows[0][conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort(字段类型:varchar,字段长度:50,是否可空:True)
 objUserWebSrvSetEN.WebApiVirtualPath = objDT.Rows[0][conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径(字段类型:varchar,字段长度:50,是否可空:True)
 objUserWebSrvSetEN.IsTemplate = TransNullToBool(objDT.Rows[0][conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objUserWebSrvSetEN.UpdDate = objDT.Rows[0][conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserWebSrvSetEN.UpdUserId = objDT.Rows[0][conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objUserWebSrvSetEN.Memo = objDT.Rows[0][conUserWebSrvSet.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserWebSrvSetDA: GetUserWebSrvSet)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsUserWebSrvSetEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
 objUserWebSrvSetEN.mId = Int32.Parse(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名(字段类型:varchar,字段长度:50,是否可空:True)
 objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort(字段类型:varchar,字段长度:50,是否可空:True)
 objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径(字段类型:varchar,字段长度:50,是否可空:True)
 objUserWebSrvSetEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserWebSrvSetDA: GetObjBymId)", objException.Message));
}
return objUserWebSrvSetEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserWebSrvSetEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN()
{
mId = TransNullToInt(objRow[conUserWebSrvSet.mId].ToString().Trim()), //mId
UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(), //用户Id
MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(), //机器名
WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(), //WebApiIPAndPort
WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(), //WebApi虚拟路径
IsTemplate = TransNullToBool(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()), //是否模板
UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim() //说明
};
objUserWebSrvSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserWebSrvSetEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserWebSrvSetDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserWebSrvSetEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = TransNullToInt(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = TransNullToBool(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserWebSrvSetDA: GetObjByDataRowUserWebSrvSet)", objException.Message));
}
objUserWebSrvSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserWebSrvSetEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserWebSrvSetEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserWebSrvSetEN objUserWebSrvSetEN = new clsUserWebSrvSetEN();
try
{
objUserWebSrvSetEN.mId = TransNullToInt(objRow[conUserWebSrvSet.mId].ToString().Trim()); //mId
objUserWebSrvSetEN.UserId = objRow[conUserWebSrvSet.UserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objUserWebSrvSetEN.MachineName = objRow[conUserWebSrvSet.MachineName] == DBNull.Value ? null : objRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objUserWebSrvSetEN.WebApiIPAndPort = objRow[conUserWebSrvSet.WebApiIPAndPort] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objUserWebSrvSetEN.WebApiVirtualPath = objRow[conUserWebSrvSet.WebApiVirtualPath] == DBNull.Value ? null : objRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objUserWebSrvSetEN.IsTemplate = TransNullToBool(objRow[conUserWebSrvSet.IsTemplate].ToString().Trim()); //是否模板
objUserWebSrvSetEN.UpdDate = objRow[conUserWebSrvSet.UpdDate] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objUserWebSrvSetEN.UpdUserId = objRow[conUserWebSrvSet.UpdUserId] == DBNull.Value ? null : objRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objUserWebSrvSetEN.Memo = objRow[conUserWebSrvSet.Memo] == DBNull.Value ? null : objRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserWebSrvSetDA: GetObjByDataRow)", objException.Message));
}
objUserWebSrvSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserWebSrvSetEN;
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
objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserWebSrvSetEN._CurrTabName, conUserWebSrvSet.mId, 8, "");
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
objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserWebSrvSetEN._CurrTabName, conUserWebSrvSet.mId, 8, strPrefix);
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from UserWebSrvSet where " + strCondition;
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from UserWebSrvSet where " + strCondition;
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserWebSrvSet", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserWebSrvSet", strCondition))
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
objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserWebSrvSet");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserWebSrvSetEN objUserWebSrvSetEN)
 {
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserWebSrvSetEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserWebSrvSet");
objRow = objDS.Tables["UserWebSrvSet"].NewRow();
 if (objUserWebSrvSetEN.UserId !=  "")
 {
objRow[conUserWebSrvSet.UserId] = objUserWebSrvSetEN.UserId; //用户Id
 }
 if (objUserWebSrvSetEN.MachineName !=  "")
 {
objRow[conUserWebSrvSet.MachineName] = objUserWebSrvSetEN.MachineName; //机器名
 }
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  "")
 {
objRow[conUserWebSrvSet.WebApiIPAndPort] = objUserWebSrvSetEN.WebApiIPAndPort; //WebApiIPAndPort
 }
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  "")
 {
objRow[conUserWebSrvSet.WebApiVirtualPath] = objUserWebSrvSetEN.WebApiVirtualPath; //WebApi虚拟路径
 }
objRow[conUserWebSrvSet.IsTemplate] = objUserWebSrvSetEN.IsTemplate; //是否模板
 if (objUserWebSrvSetEN.UpdDate !=  "")
 {
objRow[conUserWebSrvSet.UpdDate] = objUserWebSrvSetEN.UpdDate; //修改日期
 }
 if (objUserWebSrvSetEN.UpdUserId !=  "")
 {
objRow[conUserWebSrvSet.UpdUserId] = objUserWebSrvSetEN.UpdUserId; //修改用户Id
 }
 if (objUserWebSrvSetEN.Memo !=  "")
 {
objRow[conUserWebSrvSet.Memo] = objUserWebSrvSetEN.Memo; //说明
 }
objDS.Tables[clsUserWebSrvSetEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserWebSrvSetEN._CurrTabName);
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserWebSrvSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserWebSrvSetEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UserId);
 var strUserId = objUserWebSrvSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserWebSrvSetEN.MachineName !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.MachineName);
 var strMachineName = objUserWebSrvSetEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMachineName + "'");
 }
 
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.WebApiIPAndPort);
 var strWebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiIPAndPort + "'");
 }
 
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.WebApiVirtualPath);
 var strWebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiVirtualPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserWebSrvSet.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserWebSrvSetEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objUserWebSrvSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UpdDate);
 var strUpdDate = objUserWebSrvSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserWebSrvSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UpdUserId);
 var strUpdUserId = objUserWebSrvSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserWebSrvSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.Memo);
 var strMemo = objUserWebSrvSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserWebSrvSet");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserWebSrvSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserWebSrvSetEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UserId);
 var strUserId = objUserWebSrvSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserWebSrvSetEN.MachineName !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.MachineName);
 var strMachineName = objUserWebSrvSetEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMachineName + "'");
 }
 
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.WebApiIPAndPort);
 var strWebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiIPAndPort + "'");
 }
 
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.WebApiVirtualPath);
 var strWebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiVirtualPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserWebSrvSet.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserWebSrvSetEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objUserWebSrvSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UpdDate);
 var strUpdDate = objUserWebSrvSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserWebSrvSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UpdUserId);
 var strUpdUserId = objUserWebSrvSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserWebSrvSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.Memo);
 var strMemo = objUserWebSrvSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserWebSrvSet");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserWebSrvSetEN objUserWebSrvSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserWebSrvSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserWebSrvSetEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UserId);
 var strUserId = objUserWebSrvSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserWebSrvSetEN.MachineName !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.MachineName);
 var strMachineName = objUserWebSrvSetEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMachineName + "'");
 }
 
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.WebApiIPAndPort);
 var strWebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiIPAndPort + "'");
 }
 
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.WebApiVirtualPath);
 var strWebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiVirtualPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserWebSrvSet.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserWebSrvSetEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objUserWebSrvSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UpdDate);
 var strUpdDate = objUserWebSrvSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserWebSrvSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UpdUserId);
 var strUpdUserId = objUserWebSrvSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserWebSrvSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.Memo);
 var strMemo = objUserWebSrvSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserWebSrvSet");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserWebSrvSetEN objUserWebSrvSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserWebSrvSetEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserWebSrvSetEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UserId);
 var strUserId = objUserWebSrvSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserWebSrvSetEN.MachineName !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.MachineName);
 var strMachineName = objUserWebSrvSetEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMachineName + "'");
 }
 
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.WebApiIPAndPort);
 var strWebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiIPAndPort + "'");
 }
 
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.WebApiVirtualPath);
 var strWebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiVirtualPath + "'");
 }
 
 arrFieldListForInsert.Add(conUserWebSrvSet.IsTemplate);
 arrValueListForInsert.Add("'" + (objUserWebSrvSetEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objUserWebSrvSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UpdDate);
 var strUpdDate = objUserWebSrvSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objUserWebSrvSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.UpdUserId);
 var strUpdUserId = objUserWebSrvSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objUserWebSrvSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserWebSrvSet.Memo);
 var strMemo = objUserWebSrvSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserWebSrvSet");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserWebSrvSets(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserWebSrvSet");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conUserWebSrvSet.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserWebSrvSetEN._CurrTabName ].NewRow();
objRow[conUserWebSrvSet.UserId] = oRow[conUserWebSrvSet.UserId].ToString().Trim(); //用户Id
objRow[conUserWebSrvSet.MachineName] = oRow[conUserWebSrvSet.MachineName].ToString().Trim(); //机器名
objRow[conUserWebSrvSet.WebApiIPAndPort] = oRow[conUserWebSrvSet.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objRow[conUserWebSrvSet.WebApiVirtualPath] = oRow[conUserWebSrvSet.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objRow[conUserWebSrvSet.IsTemplate] = oRow[conUserWebSrvSet.IsTemplate].ToString().Trim(); //是否模板
objRow[conUserWebSrvSet.UpdDate] = oRow[conUserWebSrvSet.UpdDate].ToString().Trim(); //修改日期
objRow[conUserWebSrvSet.UpdUserId] = oRow[conUserWebSrvSet.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conUserWebSrvSet.Memo] = oRow[conUserWebSrvSet.Memo].ToString().Trim(); //说明
 objDS.Tables[clsUserWebSrvSetEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserWebSrvSetEN._CurrTabName);
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
 /// <param name = "objUserWebSrvSetEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserWebSrvSetEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
strSQL = "Select * from UserWebSrvSet where mId = " + ""+ objUserWebSrvSetEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserWebSrvSetEN._CurrTabName);
if (objDS.Tables[clsUserWebSrvSetEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objUserWebSrvSetEN.mId+"");
return false;
}
objRow = objDS.Tables[clsUserWebSrvSetEN._CurrTabName].Rows[0];
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UserId))
 {
objRow[conUserWebSrvSet.UserId] = objUserWebSrvSetEN.UserId; //用户Id
 }
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.MachineName))
 {
objRow[conUserWebSrvSet.MachineName] = objUserWebSrvSetEN.MachineName; //机器名
 }
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiIPAndPort))
 {
objRow[conUserWebSrvSet.WebApiIPAndPort] = objUserWebSrvSetEN.WebApiIPAndPort; //WebApiIPAndPort
 }
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiVirtualPath))
 {
objRow[conUserWebSrvSet.WebApiVirtualPath] = objUserWebSrvSetEN.WebApiVirtualPath; //WebApi虚拟路径
 }
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.IsTemplate))
 {
objRow[conUserWebSrvSet.IsTemplate] = objUserWebSrvSetEN.IsTemplate; //是否模板
 }
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdDate))
 {
objRow[conUserWebSrvSet.UpdDate] = objUserWebSrvSetEN.UpdDate; //修改日期
 }
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdUserId))
 {
objRow[conUserWebSrvSet.UpdUserId] = objUserWebSrvSetEN.UpdUserId; //修改用户Id
 }
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.Memo))
 {
objRow[conUserWebSrvSet.Memo] = objUserWebSrvSetEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsUserWebSrvSetEN._CurrTabName);
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserWebSrvSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserWebSrvSet Set ");
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UserId))
 {
 if (objUserWebSrvSetEN.UserId !=  null)
 {
 var strUserId = objUserWebSrvSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserWebSrvSet.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.UserId); //用户Id
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.MachineName))
 {
 if (objUserWebSrvSetEN.MachineName !=  null)
 {
 var strMachineName = objUserWebSrvSetEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMachineName, conUserWebSrvSet.MachineName); //机器名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.MachineName); //机器名
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiIPAndPort))
 {
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  null)
 {
 var strWebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiIPAndPort, conUserWebSrvSet.WebApiIPAndPort); //WebApiIPAndPort
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.WebApiIPAndPort); //WebApiIPAndPort
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiVirtualPath))
 {
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  null)
 {
 var strWebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiVirtualPath, conUserWebSrvSet.WebApiVirtualPath); //WebApi虚拟路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.WebApiVirtualPath); //WebApi虚拟路径
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserWebSrvSetEN.IsTemplate == true?"1":"0", conUserWebSrvSet.IsTemplate); //是否模板
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdDate))
 {
 if (objUserWebSrvSetEN.UpdDate !=  null)
 {
 var strUpdDate = objUserWebSrvSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserWebSrvSet.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.UpdDate); //修改日期
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdUserId))
 {
 if (objUserWebSrvSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserWebSrvSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conUserWebSrvSet.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.UpdUserId); //修改用户Id
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.Memo))
 {
 if (objUserWebSrvSetEN.Memo !=  null)
 {
 var strMemo = objUserWebSrvSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserWebSrvSet.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserWebSrvSetEN.mId); 
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
 /// <param name = "objUserWebSrvSetEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserWebSrvSetEN objUserWebSrvSetEN, string strCondition)
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserWebSrvSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserWebSrvSet Set ");
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UserId))
 {
 if (objUserWebSrvSetEN.UserId !=  null)
 {
 var strUserId = objUserWebSrvSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.MachineName))
 {
 if (objUserWebSrvSetEN.MachineName !=  null)
 {
 var strMachineName = objUserWebSrvSetEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MachineName = '{0}',", strMachineName); //机器名
 }
 else
 {
 sbSQL.Append(" MachineName = null,"); //机器名
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiIPAndPort))
 {
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  null)
 {
 var strWebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiIPAndPort = '{0}',", strWebApiIPAndPort); //WebApiIPAndPort
 }
 else
 {
 sbSQL.Append(" WebApiIPAndPort = null,"); //WebApiIPAndPort
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiVirtualPath))
 {
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  null)
 {
 var strWebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiVirtualPath = '{0}',", strWebApiVirtualPath); //WebApi虚拟路径
 }
 else
 {
 sbSQL.Append(" WebApiVirtualPath = null,"); //WebApi虚拟路径
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objUserWebSrvSetEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdDate))
 {
 if (objUserWebSrvSetEN.UpdDate !=  null)
 {
 var strUpdDate = objUserWebSrvSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdUserId))
 {
 if (objUserWebSrvSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserWebSrvSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.Memo))
 {
 if (objUserWebSrvSetEN.Memo !=  null)
 {
 var strMemo = objUserWebSrvSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserWebSrvSetEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserWebSrvSetEN objUserWebSrvSetEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserWebSrvSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserWebSrvSet Set ");
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UserId))
 {
 if (objUserWebSrvSetEN.UserId !=  null)
 {
 var strUserId = objUserWebSrvSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.MachineName))
 {
 if (objUserWebSrvSetEN.MachineName !=  null)
 {
 var strMachineName = objUserWebSrvSetEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MachineName = '{0}',", strMachineName); //机器名
 }
 else
 {
 sbSQL.Append(" MachineName = null,"); //机器名
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiIPAndPort))
 {
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  null)
 {
 var strWebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiIPAndPort = '{0}',", strWebApiIPAndPort); //WebApiIPAndPort
 }
 else
 {
 sbSQL.Append(" WebApiIPAndPort = null,"); //WebApiIPAndPort
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiVirtualPath))
 {
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  null)
 {
 var strWebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiVirtualPath = '{0}',", strWebApiVirtualPath); //WebApi虚拟路径
 }
 else
 {
 sbSQL.Append(" WebApiVirtualPath = null,"); //WebApi虚拟路径
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objUserWebSrvSetEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdDate))
 {
 if (objUserWebSrvSetEN.UpdDate !=  null)
 {
 var strUpdDate = objUserWebSrvSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdUserId))
 {
 if (objUserWebSrvSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserWebSrvSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.Memo))
 {
 if (objUserWebSrvSetEN.Memo !=  null)
 {
 var strMemo = objUserWebSrvSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserWebSrvSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserWebSrvSetEN objUserWebSrvSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objUserWebSrvSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objUserWebSrvSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserWebSrvSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserWebSrvSet Set ");
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UserId))
 {
 if (objUserWebSrvSetEN.UserId !=  null)
 {
 var strUserId = objUserWebSrvSetEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserWebSrvSet.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.UserId); //用户Id
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.MachineName))
 {
 if (objUserWebSrvSetEN.MachineName !=  null)
 {
 var strMachineName = objUserWebSrvSetEN.MachineName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMachineName, conUserWebSrvSet.MachineName); //机器名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.MachineName); //机器名
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiIPAndPort))
 {
 if (objUserWebSrvSetEN.WebApiIPAndPort !=  null)
 {
 var strWebApiIPAndPort = objUserWebSrvSetEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiIPAndPort, conUserWebSrvSet.WebApiIPAndPort); //WebApiIPAndPort
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.WebApiIPAndPort); //WebApiIPAndPort
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.WebApiVirtualPath))
 {
 if (objUserWebSrvSetEN.WebApiVirtualPath !=  null)
 {
 var strWebApiVirtualPath = objUserWebSrvSetEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiVirtualPath, conUserWebSrvSet.WebApiVirtualPath); //WebApi虚拟路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.WebApiVirtualPath); //WebApi虚拟路径
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objUserWebSrvSetEN.IsTemplate == true?"1":"0", conUserWebSrvSet.IsTemplate); //是否模板
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdDate))
 {
 if (objUserWebSrvSetEN.UpdDate !=  null)
 {
 var strUpdDate = objUserWebSrvSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conUserWebSrvSet.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.UpdDate); //修改日期
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.UpdUserId))
 {
 if (objUserWebSrvSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objUserWebSrvSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conUserWebSrvSet.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.UpdUserId); //修改用户Id
 }
 }
 
 if (objUserWebSrvSetEN.IsUpdated(conUserWebSrvSet.Memo))
 {
 if (objUserWebSrvSetEN.Memo !=  null)
 {
 var strMemo = objUserWebSrvSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserWebSrvSet.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserWebSrvSet.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserWebSrvSetEN.mId); 
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("UserWebSrvSet_Delete", values);
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
//删除UserWebSrvSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserWebSrvSet where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserWebSrvSet(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
//删除UserWebSrvSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserWebSrvSet where mId in (" + strKeyList + ")";
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
//删除UserWebSrvSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserWebSrvSet where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserWebSrvSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: DelUserWebSrvSet)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserWebSrvSet where " + strCondition ;
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
public bool DelUserWebSrvSetWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserWebSrvSetDA: DelUserWebSrvSetWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserWebSrvSet where " + strCondition ;
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
 /// <param name = "objUserWebSrvSetENS">源对象</param>
 /// <param name = "objUserWebSrvSetENT">目标对象</param>
public void CopyTo(clsUserWebSrvSetEN objUserWebSrvSetENS, clsUserWebSrvSetEN objUserWebSrvSetENT)
{
objUserWebSrvSetENT.mId = objUserWebSrvSetENS.mId; //mId
objUserWebSrvSetENT.UserId = objUserWebSrvSetENS.UserId; //用户Id
objUserWebSrvSetENT.MachineName = objUserWebSrvSetENS.MachineName; //机器名
objUserWebSrvSetENT.WebApiIPAndPort = objUserWebSrvSetENS.WebApiIPAndPort; //WebApiIPAndPort
objUserWebSrvSetENT.WebApiVirtualPath = objUserWebSrvSetENS.WebApiVirtualPath; //WebApi虚拟路径
objUserWebSrvSetENT.IsTemplate = objUserWebSrvSetENS.IsTemplate; //是否模板
objUserWebSrvSetENT.UpdDate = objUserWebSrvSetENS.UpdDate; //修改日期
objUserWebSrvSetENT.UpdUserId = objUserWebSrvSetENS.UpdUserId; //修改用户Id
objUserWebSrvSetENT.Memo = objUserWebSrvSetENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserWebSrvSetEN.IsTemplate, conUserWebSrvSet.IsTemplate);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UserId, 18, conUserWebSrvSet.UserId);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.MachineName, 50, conUserWebSrvSet.MachineName);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.WebApiIPAndPort, 50, conUserWebSrvSet.WebApiIPAndPort);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.WebApiVirtualPath, 50, conUserWebSrvSet.WebApiVirtualPath);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UpdDate, 20, conUserWebSrvSet.UpdDate);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UpdUserId, 20, conUserWebSrvSet.UpdUserId);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.Memo, 1000, conUserWebSrvSet.Memo);
//检查字段外键固定长度
 objUserWebSrvSetEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UserId, 18, conUserWebSrvSet.UserId);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.MachineName, 50, conUserWebSrvSet.MachineName);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.WebApiIPAndPort, 50, conUserWebSrvSet.WebApiIPAndPort);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.WebApiVirtualPath, 50, conUserWebSrvSet.WebApiVirtualPath);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UpdDate, 20, conUserWebSrvSet.UpdDate);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UpdUserId, 20, conUserWebSrvSet.UpdUserId);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.Memo, 1000, conUserWebSrvSet.Memo);
//检查外键字段长度
 objUserWebSrvSetEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UserId, 18, conUserWebSrvSet.UserId);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.MachineName, 50, conUserWebSrvSet.MachineName);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.WebApiIPAndPort, 50, conUserWebSrvSet.WebApiIPAndPort);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.WebApiVirtualPath, 50, conUserWebSrvSet.WebApiVirtualPath);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UpdDate, 20, conUserWebSrvSet.UpdDate);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.UpdUserId, 20, conUserWebSrvSet.UpdUserId);
clsCheckSql.CheckFieldLen(objUserWebSrvSetEN.Memo, 1000, conUserWebSrvSet.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserWebSrvSetEN.UserId, conUserWebSrvSet.UserId);
clsCheckSql.CheckSqlInjection4Field(objUserWebSrvSetEN.MachineName, conUserWebSrvSet.MachineName);
clsCheckSql.CheckSqlInjection4Field(objUserWebSrvSetEN.WebApiIPAndPort, conUserWebSrvSet.WebApiIPAndPort);
clsCheckSql.CheckSqlInjection4Field(objUserWebSrvSetEN.WebApiVirtualPath, conUserWebSrvSet.WebApiVirtualPath);
clsCheckSql.CheckSqlInjection4Field(objUserWebSrvSetEN.UpdDate, conUserWebSrvSet.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objUserWebSrvSetEN.UpdUserId, conUserWebSrvSet.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objUserWebSrvSetEN.Memo, conUserWebSrvSet.Memo);
//检查外键字段长度
 objUserWebSrvSetEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UserWebSrvSet(用户WebSrv设置),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserWebSrvSetEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUserWebSrvSetEN objUserWebSrvSetEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objUserWebSrvSetEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserWebSrvSetEN.UserId);
}
 if (objUserWebSrvSetEN.MachineName == null)
{
 sbCondition.AppendFormat(" and MachineName is null");
}
else
{
 sbCondition.AppendFormat(" and MachineName = '{0}'", objUserWebSrvSetEN.MachineName);
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserWebSrvSetEN._CurrTabName);
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserWebSrvSetEN._CurrTabName, strCondition);
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
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
 objSQL = clsUserWebSrvSetDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}