
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsProjectsDA
 表名:Projects(00050002)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
 /// 工程(Projects)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsProjectsDA : clsCommBase4DA
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
 return clsProjectsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsProjectsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsProjectsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsProjectsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsProjectsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPrjId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPrjId)
{
strPrjId = strPrjId.Replace("'", "''");
if (strPrjId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:Projects中,检查关键字,长度不正确!(clsProjectsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Projects中,关键字不能为空 或 null!(clsProjectsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsProjectsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsProjectsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Projects(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsProjectsDA: GetDataTable_Projects)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsProjectsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsProjectsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsProjectsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsProjectsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Projects where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Projects where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsProjectsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Projects where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsProjectsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Projects.* " + 
$"from Projects " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Projects.PrjId not in " + 
$"(Select top {intTop_In} Projects.PrjId from Projects " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Projects where {1} and PrjId not in (Select top {2} PrjId from Projects where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Projects where {1} and PrjId not in (Select top {3} PrjId from Projects where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsProjectsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Projects.* " + 
$"from Projects " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Projects.PrjId not in " + 
$"(Select top {intTop_In} Projects.PrjId from Projects " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Projects where {1} and PrjId not in (Select top {2} PrjId from Projects where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Projects where {1} and PrjId not in (Select top {3} PrjId from Projects where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsProjectsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsProjectsDA:GetObjLst)", objException.Message));
}
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = TransNullToBool(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = TransNullToBool(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsProjectsDA: GetObjLst)", objException.Message));
}
objProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objProjectsEN);
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
public List<clsProjectsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsProjectsDA:GetObjLstByTabName)", objException.Message));
}
List<clsProjectsEN> arrObjLst = new List<clsProjectsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = TransNullToBool(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = TransNullToBool(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsProjectsDA: GetObjLst)", objException.Message));
}
objProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objProjectsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objProjectsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetProjects(ref clsProjectsEN objProjectsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where PrjId = " + "'"+ objProjectsEN.PrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objProjectsEN.PrjId = objDT.Rows[0][conProjects.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objProjectsEN.PrjName = objDT.Rows[0][conProjects.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objProjectsEN.PrjDomain = objDT.Rows[0][conProjects.PrjDomain].ToString().Trim(); //域/包名(字段类型:varchar,字段长度:128,是否可空:True)
 objProjectsEN.TableSpace = objDT.Rows[0][conProjects.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:50,是否可空:True)
 objProjectsEN.GetWebApiFunc = objDT.Rows[0][conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数(字段类型:varchar,字段长度:100,是否可空:True)
 objProjectsEN.IsRelaDataBase = TransNullToBool(objDT.Rows[0][conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库(字段类型:bit,字段长度:1,是否可空:True)
 objProjectsEN.UseStateId = objDT.Rows[0][conProjects.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objProjectsEN.UserId = objDT.Rows[0][conProjects.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objProjectsEN.UpdDate = objDT.Rows[0][conProjects.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objProjectsEN.Memo = objDT.Rows[0][conProjects.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objProjectsEN.JavaPackageName = objDT.Rows[0][conProjects.JavaPackageName].ToString().Trim(); //Java包名(字段类型:varchar,字段长度:200,是否可空:True)
 objProjectsEN.IsSupportMvc = TransNullToBool(objDT.Rows[0][conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc(字段类型:bit,字段长度:1,是否可空:True)
 objProjectsEN.IsoPrjName = objDT.Rows[0][conProjects.IsoPrjName].ToString().Trim(); //ISO工程名(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsProjectsDA: GetProjects)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public clsProjectsEN GetObjByPrjId(string strPrjId)
{
CheckPrimaryKey(strPrjId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where PrjId = " + "'"+ strPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
 objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名(字段类型:varchar,字段长度:128,是否可空:True)
 objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间(字段类型:varchar,字段长度:50,是否可空:True)
 objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数(字段类型:varchar,字段长度:100,是否可空:True)
 objProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库(字段类型:bit,字段长度:1,是否可空:True)
 objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名(字段类型:varchar,字段长度:200,是否可空:True)
 objProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc(字段类型:bit,字段长度:1,是否可空:True)
 objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsProjectsDA: GetObjByPrjId)", objException.Message));
}
return objProjectsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsProjectsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsProjectsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsProjectsEN objProjectsEN = new clsProjectsEN()
{
PrjId = objRow[conProjects.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[conProjects.PrjName].ToString().Trim(), //工程名称
PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(), //域/包名
TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(), //表空间
GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(), //获取WebApiUrl函数
IsRelaDataBase = TransNullToBool(objRow[conProjects.IsRelaDataBase].ToString().Trim()), //是否关联数据库
UseStateId = objRow[conProjects.UseStateId].ToString().Trim(), //使用状态Id
UserId = objRow[conProjects.UserId].ToString().Trim(), //用户Id
UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(), //说明
JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(), //Java包名
IsSupportMvc = TransNullToBool(objRow[conProjects.IsSupportMvc].ToString().Trim()), //是否支持Mvc
IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim() //ISO工程名
};
objProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objProjectsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsProjectsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsProjectsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = TransNullToBool(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = TransNullToBool(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsProjectsDA: GetObjByDataRowProjects)", objException.Message));
}
objProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objProjectsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsProjectsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsProjectsEN objProjectsEN = new clsProjectsEN();
try
{
objProjectsEN.PrjId = objRow[conProjects.PrjId].ToString().Trim(); //工程Id
objProjectsEN.PrjName = objRow[conProjects.PrjName].ToString().Trim(); //工程名称
objProjectsEN.PrjDomain = objRow[conProjects.PrjDomain] == DBNull.Value ? null : objRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objProjectsEN.TableSpace = objRow[conProjects.TableSpace] == DBNull.Value ? null : objRow[conProjects.TableSpace].ToString().Trim(); //表空间
objProjectsEN.GetWebApiFunc = objRow[conProjects.GetWebApiFunc] == DBNull.Value ? null : objRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objProjectsEN.IsRelaDataBase = TransNullToBool(objRow[conProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objProjectsEN.UseStateId = objRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objProjectsEN.UserId = objRow[conProjects.UserId].ToString().Trim(); //用户Id
objProjectsEN.UpdDate = objRow[conProjects.UpdDate] == DBNull.Value ? null : objRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objProjectsEN.Memo = objRow[conProjects.Memo] == DBNull.Value ? null : objRow[conProjects.Memo].ToString().Trim(); //说明
objProjectsEN.JavaPackageName = objRow[conProjects.JavaPackageName] == DBNull.Value ? null : objRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objProjectsEN.IsSupportMvc = TransNullToBool(objRow[conProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objProjectsEN.IsoPrjName = objRow[conProjects.IsoPrjName] == DBNull.Value ? null : objRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsProjectsDA: GetObjByDataRow)", objException.Message));
}
objProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objProjectsEN;
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
objSQL = clsProjectsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsProjectsEN._CurrTabName, conProjects.PrjId, 4, "");
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
objSQL = clsProjectsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsProjectsEN._CurrTabName, conProjects.PrjId, 4, strPrefix);
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
 objSQL = clsProjectsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjId from Projects where " + strCondition;
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
 objSQL = clsProjectsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjId from Projects where " + strCondition;
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
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPrjId)
{
CheckPrimaryKey(strPrjId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Projects", "PrjId = " + "'"+ strPrjId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsProjectsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Projects", strCondition))
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
objSQL = clsProjectsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Projects");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsProjectsEN objProjectsEN)
 {
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProjectsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Projects");
objRow = objDS.Tables["Projects"].NewRow();
objRow[conProjects.PrjId] = objProjectsEN.PrjId; //工程Id
objRow[conProjects.PrjName] = objProjectsEN.PrjName; //工程名称
 if (objProjectsEN.PrjDomain !=  "")
 {
objRow[conProjects.PrjDomain] = objProjectsEN.PrjDomain; //域/包名
 }
 if (objProjectsEN.TableSpace !=  "")
 {
objRow[conProjects.TableSpace] = objProjectsEN.TableSpace; //表空间
 }
 if (objProjectsEN.GetWebApiFunc !=  "")
 {
objRow[conProjects.GetWebApiFunc] = objProjectsEN.GetWebApiFunc; //获取WebApiUrl函数
 }
objRow[conProjects.IsRelaDataBase] = objProjectsEN.IsRelaDataBase; //是否关联数据库
objRow[conProjects.UseStateId] = objProjectsEN.UseStateId; //使用状态Id
objRow[conProjects.UserId] = objProjectsEN.UserId; //用户Id
 if (objProjectsEN.UpdDate !=  "")
 {
objRow[conProjects.UpdDate] = objProjectsEN.UpdDate; //修改日期
 }
 if (objProjectsEN.Memo !=  "")
 {
objRow[conProjects.Memo] = objProjectsEN.Memo; //说明
 }
 if (objProjectsEN.JavaPackageName !=  "")
 {
objRow[conProjects.JavaPackageName] = objProjectsEN.JavaPackageName; //Java包名
 }
objRow[conProjects.IsSupportMvc] = objProjectsEN.IsSupportMvc; //是否支持Mvc
 if (objProjectsEN.IsoPrjName !=  "")
 {
objRow[conProjects.IsoPrjName] = objProjectsEN.IsoPrjName; //ISO工程名
 }
objDS.Tables[clsProjectsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsProjectsEN._CurrTabName);
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsProjectsEN objProjectsEN)
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProjectsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objProjectsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjId);
 var strPrjId = objProjectsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objProjectsEN.PrjName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjName);
 var strPrjName = objProjectsEN.PrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjName + "'");
 }
 
 if (objProjectsEN.PrjDomain !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjDomain);
 var strPrjDomain = objProjectsEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDomain + "'");
 }
 
 if (objProjectsEN.TableSpace !=  null)
 {
 arrFieldListForInsert.Add(conProjects.TableSpace);
 var strTableSpace = objProjectsEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableSpace + "'");
 }
 
 if (objProjectsEN.GetWebApiFunc !=  null)
 {
 arrFieldListForInsert.Add(conProjects.GetWebApiFunc);
 var strGetWebApiFunc = objProjectsEN.GetWebApiFunc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetWebApiFunc + "'");
 }
 
 arrFieldListForInsert.Add(conProjects.IsRelaDataBase);
 arrValueListForInsert.Add("'" + (objProjectsEN.IsRelaDataBase  ==  false ? "0" : "1") + "'");
 
 if (objProjectsEN.UseStateId  ==  "")
 {
 objProjectsEN.UseStateId = null;
 }
 if (objProjectsEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UseStateId);
 var strUseStateId = objProjectsEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objProjectsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UserId);
 var strUserId = objProjectsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objProjectsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UpdDate);
 var strUpdDate = objProjectsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objProjectsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conProjects.Memo);
 var strMemo = objProjectsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objProjectsEN.JavaPackageName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.JavaPackageName);
 var strJavaPackageName = objProjectsEN.JavaPackageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaPackageName + "'");
 }
 
 arrFieldListForInsert.Add(conProjects.IsSupportMvc);
 arrValueListForInsert.Add("'" + (objProjectsEN.IsSupportMvc  ==  false ? "0" : "1") + "'");
 
 if (objProjectsEN.IsoPrjName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.IsoPrjName);
 var strIsoPrjName = objProjectsEN.IsoPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIsoPrjName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Projects");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsProjectsEN objProjectsEN)
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProjectsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objProjectsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjId);
 var strPrjId = objProjectsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objProjectsEN.PrjName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjName);
 var strPrjName = objProjectsEN.PrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjName + "'");
 }
 
 if (objProjectsEN.PrjDomain !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjDomain);
 var strPrjDomain = objProjectsEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDomain + "'");
 }
 
 if (objProjectsEN.TableSpace !=  null)
 {
 arrFieldListForInsert.Add(conProjects.TableSpace);
 var strTableSpace = objProjectsEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableSpace + "'");
 }
 
 if (objProjectsEN.GetWebApiFunc !=  null)
 {
 arrFieldListForInsert.Add(conProjects.GetWebApiFunc);
 var strGetWebApiFunc = objProjectsEN.GetWebApiFunc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetWebApiFunc + "'");
 }
 
 arrFieldListForInsert.Add(conProjects.IsRelaDataBase);
 arrValueListForInsert.Add("'" + (objProjectsEN.IsRelaDataBase  ==  false ? "0" : "1") + "'");
 
 if (objProjectsEN.UseStateId  ==  "")
 {
 objProjectsEN.UseStateId = null;
 }
 if (objProjectsEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UseStateId);
 var strUseStateId = objProjectsEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objProjectsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UserId);
 var strUserId = objProjectsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objProjectsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UpdDate);
 var strUpdDate = objProjectsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objProjectsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conProjects.Memo);
 var strMemo = objProjectsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objProjectsEN.JavaPackageName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.JavaPackageName);
 var strJavaPackageName = objProjectsEN.JavaPackageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaPackageName + "'");
 }
 
 arrFieldListForInsert.Add(conProjects.IsSupportMvc);
 arrValueListForInsert.Add("'" + (objProjectsEN.IsSupportMvc  ==  false ? "0" : "1") + "'");
 
 if (objProjectsEN.IsoPrjName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.IsoPrjName);
 var strIsoPrjName = objProjectsEN.IsoPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIsoPrjName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Projects");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objProjectsEN.PrjId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsProjectsEN objProjectsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProjectsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objProjectsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjId);
 var strPrjId = objProjectsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objProjectsEN.PrjName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjName);
 var strPrjName = objProjectsEN.PrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjName + "'");
 }
 
 if (objProjectsEN.PrjDomain !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjDomain);
 var strPrjDomain = objProjectsEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDomain + "'");
 }
 
 if (objProjectsEN.TableSpace !=  null)
 {
 arrFieldListForInsert.Add(conProjects.TableSpace);
 var strTableSpace = objProjectsEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableSpace + "'");
 }
 
 if (objProjectsEN.GetWebApiFunc !=  null)
 {
 arrFieldListForInsert.Add(conProjects.GetWebApiFunc);
 var strGetWebApiFunc = objProjectsEN.GetWebApiFunc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetWebApiFunc + "'");
 }
 
 arrFieldListForInsert.Add(conProjects.IsRelaDataBase);
 arrValueListForInsert.Add("'" + (objProjectsEN.IsRelaDataBase  ==  false ? "0" : "1") + "'");
 
 if (objProjectsEN.UseStateId  ==  "")
 {
 objProjectsEN.UseStateId = null;
 }
 if (objProjectsEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UseStateId);
 var strUseStateId = objProjectsEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objProjectsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UserId);
 var strUserId = objProjectsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objProjectsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UpdDate);
 var strUpdDate = objProjectsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objProjectsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conProjects.Memo);
 var strMemo = objProjectsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objProjectsEN.JavaPackageName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.JavaPackageName);
 var strJavaPackageName = objProjectsEN.JavaPackageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaPackageName + "'");
 }
 
 arrFieldListForInsert.Add(conProjects.IsSupportMvc);
 arrValueListForInsert.Add("'" + (objProjectsEN.IsSupportMvc  ==  false ? "0" : "1") + "'");
 
 if (objProjectsEN.IsoPrjName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.IsoPrjName);
 var strIsoPrjName = objProjectsEN.IsoPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIsoPrjName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Projects");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objProjectsEN.PrjId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsProjectsEN objProjectsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objProjectsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objProjectsEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjId);
 var strPrjId = objProjectsEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objProjectsEN.PrjName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjName);
 var strPrjName = objProjectsEN.PrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjName + "'");
 }
 
 if (objProjectsEN.PrjDomain !=  null)
 {
 arrFieldListForInsert.Add(conProjects.PrjDomain);
 var strPrjDomain = objProjectsEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDomain + "'");
 }
 
 if (objProjectsEN.TableSpace !=  null)
 {
 arrFieldListForInsert.Add(conProjects.TableSpace);
 var strTableSpace = objProjectsEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTableSpace + "'");
 }
 
 if (objProjectsEN.GetWebApiFunc !=  null)
 {
 arrFieldListForInsert.Add(conProjects.GetWebApiFunc);
 var strGetWebApiFunc = objProjectsEN.GetWebApiFunc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetWebApiFunc + "'");
 }
 
 arrFieldListForInsert.Add(conProjects.IsRelaDataBase);
 arrValueListForInsert.Add("'" + (objProjectsEN.IsRelaDataBase  ==  false ? "0" : "1") + "'");
 
 if (objProjectsEN.UseStateId  ==  "")
 {
 objProjectsEN.UseStateId = null;
 }
 if (objProjectsEN.UseStateId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UseStateId);
 var strUseStateId = objProjectsEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseStateId + "'");
 }
 
 if (objProjectsEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UserId);
 var strUserId = objProjectsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objProjectsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conProjects.UpdDate);
 var strUpdDate = objProjectsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objProjectsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conProjects.Memo);
 var strMemo = objProjectsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objProjectsEN.JavaPackageName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.JavaPackageName);
 var strJavaPackageName = objProjectsEN.JavaPackageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strJavaPackageName + "'");
 }
 
 arrFieldListForInsert.Add(conProjects.IsSupportMvc);
 arrValueListForInsert.Add("'" + (objProjectsEN.IsSupportMvc  ==  false ? "0" : "1") + "'");
 
 if (objProjectsEN.IsoPrjName !=  null)
 {
 arrFieldListForInsert.Add(conProjects.IsoPrjName);
 var strIsoPrjName = objProjectsEN.IsoPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIsoPrjName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Projects");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewProjectss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where PrjId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Projects");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPrjId = oRow[conProjects.PrjId].ToString().Trim();
if (IsExist(strPrjId))
{
 string strResult = "关键字变量值为:" + string.Format("PrjId = {0}", strPrjId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsProjectsEN._CurrTabName ].NewRow();
objRow[conProjects.PrjId] = oRow[conProjects.PrjId].ToString().Trim(); //工程Id
objRow[conProjects.PrjName] = oRow[conProjects.PrjName].ToString().Trim(); //工程名称
objRow[conProjects.PrjDomain] = oRow[conProjects.PrjDomain].ToString().Trim(); //域/包名
objRow[conProjects.TableSpace] = oRow[conProjects.TableSpace].ToString().Trim(); //表空间
objRow[conProjects.GetWebApiFunc] = oRow[conProjects.GetWebApiFunc].ToString().Trim(); //获取WebApiUrl函数
objRow[conProjects.IsRelaDataBase] = oRow[conProjects.IsRelaDataBase].ToString().Trim(); //是否关联数据库
objRow[conProjects.UseStateId] = oRow[conProjects.UseStateId].ToString().Trim(); //使用状态Id
objRow[conProjects.UserId] = oRow[conProjects.UserId].ToString().Trim(); //用户Id
objRow[conProjects.UpdDate] = oRow[conProjects.UpdDate].ToString().Trim(); //修改日期
objRow[conProjects.Memo] = oRow[conProjects.Memo].ToString().Trim(); //说明
objRow[conProjects.JavaPackageName] = oRow[conProjects.JavaPackageName].ToString().Trim(); //Java包名
objRow[conProjects.IsSupportMvc] = oRow[conProjects.IsSupportMvc].ToString().Trim(); //是否支持Mvc
objRow[conProjects.IsoPrjName] = oRow[conProjects.IsoPrjName].ToString().Trim(); //ISO工程名
 objDS.Tables[clsProjectsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsProjectsEN._CurrTabName);
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
 /// <param name = "objProjectsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsProjectsEN objProjectsEN)
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProjectsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
strSQL = "Select * from Projects where PrjId = " + "'"+ objProjectsEN.PrjId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsProjectsEN._CurrTabName);
if (objDS.Tables[clsProjectsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PrjId = " + "'"+ objProjectsEN.PrjId+"'");
return false;
}
objRow = objDS.Tables[clsProjectsEN._CurrTabName].Rows[0];
 if (objProjectsEN.IsUpdated(conProjects.PrjId))
 {
objRow[conProjects.PrjId] = objProjectsEN.PrjId; //工程Id
 }
 if (objProjectsEN.IsUpdated(conProjects.PrjName))
 {
objRow[conProjects.PrjName] = objProjectsEN.PrjName; //工程名称
 }
 if (objProjectsEN.IsUpdated(conProjects.PrjDomain))
 {
objRow[conProjects.PrjDomain] = objProjectsEN.PrjDomain; //域/包名
 }
 if (objProjectsEN.IsUpdated(conProjects.TableSpace))
 {
objRow[conProjects.TableSpace] = objProjectsEN.TableSpace; //表空间
 }
 if (objProjectsEN.IsUpdated(conProjects.GetWebApiFunc))
 {
objRow[conProjects.GetWebApiFunc] = objProjectsEN.GetWebApiFunc; //获取WebApiUrl函数
 }
 if (objProjectsEN.IsUpdated(conProjects.IsRelaDataBase))
 {
objRow[conProjects.IsRelaDataBase] = objProjectsEN.IsRelaDataBase; //是否关联数据库
 }
 if (objProjectsEN.IsUpdated(conProjects.UseStateId))
 {
objRow[conProjects.UseStateId] = objProjectsEN.UseStateId; //使用状态Id
 }
 if (objProjectsEN.IsUpdated(conProjects.UserId))
 {
objRow[conProjects.UserId] = objProjectsEN.UserId; //用户Id
 }
 if (objProjectsEN.IsUpdated(conProjects.UpdDate))
 {
objRow[conProjects.UpdDate] = objProjectsEN.UpdDate; //修改日期
 }
 if (objProjectsEN.IsUpdated(conProjects.Memo))
 {
objRow[conProjects.Memo] = objProjectsEN.Memo; //说明
 }
 if (objProjectsEN.IsUpdated(conProjects.JavaPackageName))
 {
objRow[conProjects.JavaPackageName] = objProjectsEN.JavaPackageName; //Java包名
 }
 if (objProjectsEN.IsUpdated(conProjects.IsSupportMvc))
 {
objRow[conProjects.IsSupportMvc] = objProjectsEN.IsSupportMvc; //是否支持Mvc
 }
 if (objProjectsEN.IsUpdated(conProjects.IsoPrjName))
 {
objRow[conProjects.IsoPrjName] = objProjectsEN.IsoPrjName; //ISO工程名
 }
try
{
objDA.Update(objDS, clsProjectsEN._CurrTabName);
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsProjectsEN objProjectsEN)
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProjectsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Projects Set ");
 
 if (objProjectsEN.IsUpdated(conProjects.PrjName))
 {
 if (objProjectsEN.PrjName !=  null)
 {
 var strPrjName = objProjectsEN.PrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjName, conProjects.PrjName); //工程名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.PrjName); //工程名称
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.PrjDomain))
 {
 if (objProjectsEN.PrjDomain !=  null)
 {
 var strPrjDomain = objProjectsEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjDomain, conProjects.PrjDomain); //域/包名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.PrjDomain); //域/包名
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.TableSpace))
 {
 if (objProjectsEN.TableSpace !=  null)
 {
 var strTableSpace = objProjectsEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableSpace, conProjects.TableSpace); //表空间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.TableSpace); //表空间
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.GetWebApiFunc))
 {
 if (objProjectsEN.GetWebApiFunc !=  null)
 {
 var strGetWebApiFunc = objProjectsEN.GetWebApiFunc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetWebApiFunc, conProjects.GetWebApiFunc); //获取WebApiUrl函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.GetWebApiFunc); //获取WebApiUrl函数
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsRelaDataBase))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objProjectsEN.IsRelaDataBase == true?"1":"0", conProjects.IsRelaDataBase); //是否关联数据库
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UseStateId))
 {
 if (objProjectsEN.UseStateId  ==  "")
 {
 objProjectsEN.UseStateId = null;
 }
 if (objProjectsEN.UseStateId !=  null)
 {
 var strUseStateId = objProjectsEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conProjects.UseStateId); //使用状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.UseStateId); //使用状态Id
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UserId))
 {
 if (objProjectsEN.UserId !=  null)
 {
 var strUserId = objProjectsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conProjects.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.UserId); //用户Id
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UpdDate))
 {
 if (objProjectsEN.UpdDate !=  null)
 {
 var strUpdDate = objProjectsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conProjects.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.UpdDate); //修改日期
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.Memo))
 {
 if (objProjectsEN.Memo !=  null)
 {
 var strMemo = objProjectsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conProjects.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.Memo); //说明
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.JavaPackageName))
 {
 if (objProjectsEN.JavaPackageName !=  null)
 {
 var strJavaPackageName = objProjectsEN.JavaPackageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaPackageName, conProjects.JavaPackageName); //Java包名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.JavaPackageName); //Java包名
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsSupportMvc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objProjectsEN.IsSupportMvc == true?"1":"0", conProjects.IsSupportMvc); //是否支持Mvc
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsoPrjName))
 {
 if (objProjectsEN.IsoPrjName !=  null)
 {
 var strIsoPrjName = objProjectsEN.IsoPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIsoPrjName, conProjects.IsoPrjName); //ISO工程名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.IsoPrjName); //ISO工程名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjId = '{0}'", objProjectsEN.PrjId); 
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
 /// <param name = "objProjectsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsProjectsEN objProjectsEN, string strCondition)
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProjectsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Projects Set ");
 
 if (objProjectsEN.IsUpdated(conProjects.PrjName))
 {
 if (objProjectsEN.PrjName !=  null)
 {
 var strPrjName = objProjectsEN.PrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjName = '{0}',", strPrjName); //工程名称
 }
 else
 {
 sbSQL.Append(" PrjName = null,"); //工程名称
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.PrjDomain))
 {
 if (objProjectsEN.PrjDomain !=  null)
 {
 var strPrjDomain = objProjectsEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjDomain = '{0}',", strPrjDomain); //域/包名
 }
 else
 {
 sbSQL.Append(" PrjDomain = null,"); //域/包名
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.TableSpace))
 {
 if (objProjectsEN.TableSpace !=  null)
 {
 var strTableSpace = objProjectsEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableSpace = '{0}',", strTableSpace); //表空间
 }
 else
 {
 sbSQL.Append(" TableSpace = null,"); //表空间
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.GetWebApiFunc))
 {
 if (objProjectsEN.GetWebApiFunc !=  null)
 {
 var strGetWebApiFunc = objProjectsEN.GetWebApiFunc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetWebApiFunc = '{0}',", strGetWebApiFunc); //获取WebApiUrl函数
 }
 else
 {
 sbSQL.Append(" GetWebApiFunc = null,"); //获取WebApiUrl函数
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsRelaDataBase))
 {
 sbSQL.AppendFormat(" IsRelaDataBase = '{0}',", objProjectsEN.IsRelaDataBase == true?"1":"0"); //是否关联数据库
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UseStateId))
 {
 if (objProjectsEN.UseStateId  ==  "")
 {
 objProjectsEN.UseStateId = null;
 }
 if (objProjectsEN.UseStateId !=  null)
 {
 var strUseStateId = objProjectsEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //使用状态Id
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //使用状态Id
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UserId))
 {
 if (objProjectsEN.UserId !=  null)
 {
 var strUserId = objProjectsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UpdDate))
 {
 if (objProjectsEN.UpdDate !=  null)
 {
 var strUpdDate = objProjectsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.Memo))
 {
 if (objProjectsEN.Memo !=  null)
 {
 var strMemo = objProjectsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.JavaPackageName))
 {
 if (objProjectsEN.JavaPackageName !=  null)
 {
 var strJavaPackageName = objProjectsEN.JavaPackageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaPackageName = '{0}',", strJavaPackageName); //Java包名
 }
 else
 {
 sbSQL.Append(" JavaPackageName = null,"); //Java包名
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsSupportMvc))
 {
 sbSQL.AppendFormat(" IsSupportMvc = '{0}',", objProjectsEN.IsSupportMvc == true?"1":"0"); //是否支持Mvc
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsoPrjName))
 {
 if (objProjectsEN.IsoPrjName !=  null)
 {
 var strIsoPrjName = objProjectsEN.IsoPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IsoPrjName = '{0}',", strIsoPrjName); //ISO工程名
 }
 else
 {
 sbSQL.Append(" IsoPrjName = null,"); //ISO工程名
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
 /// <param name = "objProjectsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsProjectsEN objProjectsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProjectsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Projects Set ");
 
 if (objProjectsEN.IsUpdated(conProjects.PrjName))
 {
 if (objProjectsEN.PrjName !=  null)
 {
 var strPrjName = objProjectsEN.PrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjName = '{0}',", strPrjName); //工程名称
 }
 else
 {
 sbSQL.Append(" PrjName = null,"); //工程名称
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.PrjDomain))
 {
 if (objProjectsEN.PrjDomain !=  null)
 {
 var strPrjDomain = objProjectsEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjDomain = '{0}',", strPrjDomain); //域/包名
 }
 else
 {
 sbSQL.Append(" PrjDomain = null,"); //域/包名
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.TableSpace))
 {
 if (objProjectsEN.TableSpace !=  null)
 {
 var strTableSpace = objProjectsEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TableSpace = '{0}',", strTableSpace); //表空间
 }
 else
 {
 sbSQL.Append(" TableSpace = null,"); //表空间
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.GetWebApiFunc))
 {
 if (objProjectsEN.GetWebApiFunc !=  null)
 {
 var strGetWebApiFunc = objProjectsEN.GetWebApiFunc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetWebApiFunc = '{0}',", strGetWebApiFunc); //获取WebApiUrl函数
 }
 else
 {
 sbSQL.Append(" GetWebApiFunc = null,"); //获取WebApiUrl函数
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsRelaDataBase))
 {
 sbSQL.AppendFormat(" IsRelaDataBase = '{0}',", objProjectsEN.IsRelaDataBase == true?"1":"0"); //是否关联数据库
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UseStateId))
 {
 if (objProjectsEN.UseStateId  ==  "")
 {
 objProjectsEN.UseStateId = null;
 }
 if (objProjectsEN.UseStateId !=  null)
 {
 var strUseStateId = objProjectsEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseStateId = '{0}',", strUseStateId); //使用状态Id
 }
 else
 {
 sbSQL.Append(" UseStateId = null,"); //使用状态Id
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UserId))
 {
 if (objProjectsEN.UserId !=  null)
 {
 var strUserId = objProjectsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UpdDate))
 {
 if (objProjectsEN.UpdDate !=  null)
 {
 var strUpdDate = objProjectsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.Memo))
 {
 if (objProjectsEN.Memo !=  null)
 {
 var strMemo = objProjectsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.JavaPackageName))
 {
 if (objProjectsEN.JavaPackageName !=  null)
 {
 var strJavaPackageName = objProjectsEN.JavaPackageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" JavaPackageName = '{0}',", strJavaPackageName); //Java包名
 }
 else
 {
 sbSQL.Append(" JavaPackageName = null,"); //Java包名
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsSupportMvc))
 {
 sbSQL.AppendFormat(" IsSupportMvc = '{0}',", objProjectsEN.IsSupportMvc == true?"1":"0"); //是否支持Mvc
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsoPrjName))
 {
 if (objProjectsEN.IsoPrjName !=  null)
 {
 var strIsoPrjName = objProjectsEN.IsoPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IsoPrjName = '{0}',", strIsoPrjName); //ISO工程名
 }
 else
 {
 sbSQL.Append(" IsoPrjName = null,"); //ISO工程名
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
 /// <param name = "objProjectsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsProjectsEN objProjectsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objProjectsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objProjectsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objProjectsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Projects Set ");
 
 if (objProjectsEN.IsUpdated(conProjects.PrjName))
 {
 if (objProjectsEN.PrjName !=  null)
 {
 var strPrjName = objProjectsEN.PrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjName, conProjects.PrjName); //工程名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.PrjName); //工程名称
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.PrjDomain))
 {
 if (objProjectsEN.PrjDomain !=  null)
 {
 var strPrjDomain = objProjectsEN.PrjDomain.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjDomain, conProjects.PrjDomain); //域/包名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.PrjDomain); //域/包名
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.TableSpace))
 {
 if (objProjectsEN.TableSpace !=  null)
 {
 var strTableSpace = objProjectsEN.TableSpace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTableSpace, conProjects.TableSpace); //表空间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.TableSpace); //表空间
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.GetWebApiFunc))
 {
 if (objProjectsEN.GetWebApiFunc !=  null)
 {
 var strGetWebApiFunc = objProjectsEN.GetWebApiFunc.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetWebApiFunc, conProjects.GetWebApiFunc); //获取WebApiUrl函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.GetWebApiFunc); //获取WebApiUrl函数
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsRelaDataBase))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objProjectsEN.IsRelaDataBase == true?"1":"0", conProjects.IsRelaDataBase); //是否关联数据库
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UseStateId))
 {
 if (objProjectsEN.UseStateId  ==  "")
 {
 objProjectsEN.UseStateId = null;
 }
 if (objProjectsEN.UseStateId !=  null)
 {
 var strUseStateId = objProjectsEN.UseStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseStateId, conProjects.UseStateId); //使用状态Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.UseStateId); //使用状态Id
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UserId))
 {
 if (objProjectsEN.UserId !=  null)
 {
 var strUserId = objProjectsEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conProjects.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.UserId); //用户Id
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.UpdDate))
 {
 if (objProjectsEN.UpdDate !=  null)
 {
 var strUpdDate = objProjectsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conProjects.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.UpdDate); //修改日期
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.Memo))
 {
 if (objProjectsEN.Memo !=  null)
 {
 var strMemo = objProjectsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conProjects.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.Memo); //说明
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.JavaPackageName))
 {
 if (objProjectsEN.JavaPackageName !=  null)
 {
 var strJavaPackageName = objProjectsEN.JavaPackageName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strJavaPackageName, conProjects.JavaPackageName); //Java包名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.JavaPackageName); //Java包名
 }
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsSupportMvc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objProjectsEN.IsSupportMvc == true?"1":"0", conProjects.IsSupportMvc); //是否支持Mvc
 }
 
 if (objProjectsEN.IsUpdated(conProjects.IsoPrjName))
 {
 if (objProjectsEN.IsoPrjName !=  null)
 {
 var strIsoPrjName = objProjectsEN.IsoPrjName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIsoPrjName, conProjects.IsoPrjName); //ISO工程名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conProjects.IsoPrjName); //ISO工程名
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PrjId = '{0}'", objProjectsEN.PrjId); 
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
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPrjId) 
{
CheckPrimaryKey(strPrjId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPrjId,
};
 objSQL.ExecSP("Projects_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPrjId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPrjId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
//删除Projects本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Projects where PrjId = " + "'"+ strPrjId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelProjects(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
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
//删除Projects本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Projects where PrjId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPrjId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPrjId) 
{
CheckPrimaryKey(strPrjId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
//删除Projects本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Projects where PrjId = " + "'"+ strPrjId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelProjects(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsProjectsDA: DelProjects)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Projects where " + strCondition ;
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
public bool DelProjectsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsProjectsDA: DelProjectsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsProjectsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Projects where " + strCondition ;
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
 /// <param name = "objProjectsENS">源对象</param>
 /// <param name = "objProjectsENT">目标对象</param>
public void CopyTo(clsProjectsEN objProjectsENS, clsProjectsEN objProjectsENT)
{
objProjectsENT.PrjId = objProjectsENS.PrjId; //工程Id
objProjectsENT.PrjName = objProjectsENS.PrjName; //工程名称
objProjectsENT.PrjDomain = objProjectsENS.PrjDomain; //域/包名
objProjectsENT.TableSpace = objProjectsENS.TableSpace; //表空间
objProjectsENT.GetWebApiFunc = objProjectsENS.GetWebApiFunc; //获取WebApiUrl函数
objProjectsENT.IsRelaDataBase = objProjectsENS.IsRelaDataBase; //是否关联数据库
objProjectsENT.UseStateId = objProjectsENS.UseStateId; //使用状态Id
objProjectsENT.UserId = objProjectsENS.UserId; //用户Id
objProjectsENT.UpdDate = objProjectsENS.UpdDate; //修改日期
objProjectsENT.Memo = objProjectsENS.Memo; //说明
objProjectsENT.JavaPackageName = objProjectsENS.JavaPackageName; //Java包名
objProjectsENT.IsSupportMvc = objProjectsENS.IsSupportMvc; //是否支持Mvc
objProjectsENT.IsoPrjName = objProjectsENS.IsoPrjName; //ISO工程名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsProjectsEN objProjectsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objProjectsEN.PrjName, conProjects.PrjName);
clsCheckSql.CheckFieldNotNull(objProjectsEN.UseStateId, conProjects.UseStateId);
clsCheckSql.CheckFieldNotNull(objProjectsEN.UserId, conProjects.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objProjectsEN.PrjId, 4, conProjects.PrjId);
clsCheckSql.CheckFieldLen(objProjectsEN.PrjName, 30, conProjects.PrjName);
clsCheckSql.CheckFieldLen(objProjectsEN.PrjDomain, 128, conProjects.PrjDomain);
clsCheckSql.CheckFieldLen(objProjectsEN.TableSpace, 50, conProjects.TableSpace);
clsCheckSql.CheckFieldLen(objProjectsEN.GetWebApiFunc, 100, conProjects.GetWebApiFunc);
clsCheckSql.CheckFieldLen(objProjectsEN.UseStateId, 4, conProjects.UseStateId);
clsCheckSql.CheckFieldLen(objProjectsEN.UserId, 18, conProjects.UserId);
clsCheckSql.CheckFieldLen(objProjectsEN.UpdDate, 20, conProjects.UpdDate);
clsCheckSql.CheckFieldLen(objProjectsEN.Memo, 1000, conProjects.Memo);
clsCheckSql.CheckFieldLen(objProjectsEN.JavaPackageName, 200, conProjects.JavaPackageName);
clsCheckSql.CheckFieldLen(objProjectsEN.IsoPrjName, 50, conProjects.IsoPrjName);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objProjectsEN.UseStateId, 4, conProjects.UseStateId);
 objProjectsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsProjectsEN objProjectsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objProjectsEN.PrjName, 30, conProjects.PrjName);
clsCheckSql.CheckFieldLen(objProjectsEN.PrjDomain, 128, conProjects.PrjDomain);
clsCheckSql.CheckFieldLen(objProjectsEN.TableSpace, 50, conProjects.TableSpace);
clsCheckSql.CheckFieldLen(objProjectsEN.GetWebApiFunc, 100, conProjects.GetWebApiFunc);
clsCheckSql.CheckFieldLen(objProjectsEN.UseStateId, 4, conProjects.UseStateId);
clsCheckSql.CheckFieldLen(objProjectsEN.UserId, 18, conProjects.UserId);
clsCheckSql.CheckFieldLen(objProjectsEN.UpdDate, 20, conProjects.UpdDate);
clsCheckSql.CheckFieldLen(objProjectsEN.Memo, 1000, conProjects.Memo);
clsCheckSql.CheckFieldLen(objProjectsEN.JavaPackageName, 200, conProjects.JavaPackageName);
clsCheckSql.CheckFieldLen(objProjectsEN.IsoPrjName, 50, conProjects.IsoPrjName);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objProjectsEN.UseStateId, 4, conProjects.UseStateId);
 objProjectsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsProjectsEN objProjectsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objProjectsEN.PrjId, 4, conProjects.PrjId);
clsCheckSql.CheckFieldLen(objProjectsEN.PrjName, 30, conProjects.PrjName);
clsCheckSql.CheckFieldLen(objProjectsEN.PrjDomain, 128, conProjects.PrjDomain);
clsCheckSql.CheckFieldLen(objProjectsEN.TableSpace, 50, conProjects.TableSpace);
clsCheckSql.CheckFieldLen(objProjectsEN.GetWebApiFunc, 100, conProjects.GetWebApiFunc);
clsCheckSql.CheckFieldLen(objProjectsEN.UseStateId, 4, conProjects.UseStateId);
clsCheckSql.CheckFieldLen(objProjectsEN.UserId, 18, conProjects.UserId);
clsCheckSql.CheckFieldLen(objProjectsEN.UpdDate, 20, conProjects.UpdDate);
clsCheckSql.CheckFieldLen(objProjectsEN.Memo, 1000, conProjects.Memo);
clsCheckSql.CheckFieldLen(objProjectsEN.JavaPackageName, 200, conProjects.JavaPackageName);
clsCheckSql.CheckFieldLen(objProjectsEN.IsoPrjName, 50, conProjects.IsoPrjName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.PrjId, conProjects.PrjId);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.PrjName, conProjects.PrjName);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.PrjDomain, conProjects.PrjDomain);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.TableSpace, conProjects.TableSpace);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.GetWebApiFunc, conProjects.GetWebApiFunc);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.UseStateId, conProjects.UseStateId);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.UserId, conProjects.UserId);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.UpdDate, conProjects.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.Memo, conProjects.Memo);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.JavaPackageName, conProjects.JavaPackageName);
clsCheckSql.CheckSqlInjection4Field(objProjectsEN.IsoPrjName, conProjects.IsoPrjName);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objProjectsEN.UseStateId, 4, conProjects.UseStateId);
 objProjectsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPrjId()
{
//获取某学院所有专业信息
string strSQL = "select PrjId, PrjName from Projects ";
 clsSpecSQLforSql mySql = clsProjectsDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Projects(工程),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objProjectsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsProjectsEN objProjectsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjName = '{0}'", objProjectsEN.PrjName);
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
 objSQL = clsProjectsDA.GetSpecSQLObj();
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
 objSQL = clsProjectsDA.GetSpecSQLObj();
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
 objSQL = clsProjectsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsProjectsEN._CurrTabName);
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
 objSQL = clsProjectsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsProjectsEN._CurrTabName, strCondition);
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
 objSQL = clsProjectsDA.GetSpecSQLObj();
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
 objSQL = clsProjectsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}