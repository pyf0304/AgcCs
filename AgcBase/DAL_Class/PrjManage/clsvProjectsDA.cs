
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvProjectsDA
 表名:vProjects(00050167)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:52
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// v工程(vProjects)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvProjectsDA : clsCommBase4DA
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
 return clsvProjectsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvProjectsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvProjectsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvProjectsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvProjectsEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vProjects中,检查关键字,长度不正确!(clsvProjectsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPrjId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vProjects中,关键字不能为空 或 null!(clsvProjectsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPrjId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvProjectsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
strSQL = "Select * from vProjects where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vProjects(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTable_vProjects)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
strSQL = "Select * from vProjects where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
strSQL = "Select * from vProjects where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProjects where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProjects where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vProjects where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vProjects.* " + 
$"from vProjects " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vProjects.PrjId not in " + 
$"(Select top {intTop_In} vProjects.PrjId from vProjects " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProjects where {1} and PrjId not in (Select top {2} PrjId from vProjects where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProjects where {1} and PrjId not in (Select top {3} PrjId from vProjects where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvProjectsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vProjects.* " + 
$"from vProjects " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vProjects.PrjId not in " + 
$"(Select top {intTop_In} vProjects.PrjId from vProjects " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vProjects where {1} and PrjId not in (Select top {2} PrjId from vProjects where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vProjects where {1} and PrjId not in (Select top {3} PrjId from vProjects where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvProjectsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvProjectsDA:GetObjLst)", objException.Message));
}
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
strSQL = "Select * from vProjects where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = TransNullToBool(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = TransNullToInt(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = TransNullToBool(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvProjectsDA: GetObjLst)", objException.Message));
}
objvProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvProjectsEN);
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
public List<clsvProjectsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvProjectsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvProjectsEN> arrObjLst = new List<clsvProjectsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = TransNullToBool(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = TransNullToInt(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = TransNullToBool(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvProjectsDA: GetObjLst)", objException.Message));
}
objvProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvProjectsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvProjectsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvProjects(ref clsvProjectsEN objvProjectsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
strSQL = "Select * from vProjects where PrjId = " + "'"+ objvProjectsEN.PrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvProjectsEN.PrjId = objDT.Rows[0][convProjects.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectsEN.PrjName = objDT.Rows[0][convProjects.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectsEN.PrjDomain = objDT.Rows[0][convProjects.PrjDomain].ToString().Trim(); //域/包名(字段类型:varchar,字段长度:128,是否可空:True)
 objvProjectsEN.IsoPrjName = objDT.Rows[0][convProjects.IsoPrjName].ToString().Trim(); //ISO工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvProjectsEN.JavaPackageName = objDT.Rows[0][convProjects.JavaPackageName].ToString().Trim(); //Java包名(字段类型:varchar,字段长度:200,是否可空:True)
 objvProjectsEN.IsRelaDataBase = TransNullToBool(objDT.Rows[0][convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库(字段类型:bit,字段长度:1,是否可空:True)
 objvProjectsEN.SoftStructureId = objDT.Rows[0][convProjects.SoftStructureId].ToString().Trim(); //架构ID(字段类型:char,字段长度:4,是否可空:False)
 objvProjectsEN.SoftStructureName = objDT.Rows[0][convProjects.SoftStructureName].ToString().Trim(); //架构名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvProjectsEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvProjectsEN.ApplicationTypeName = objDT.Rows[0][convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectsEN.UseStateId = objDT.Rows[0][convProjects.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectsEN.UseStateName = objDT.Rows[0][convProjects.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectsEN.IsSupportMvc = TransNullToBool(objDT.Rows[0][convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc(字段类型:bit,字段长度:1,是否可空:True)
 objvProjectsEN.UserId = objDT.Rows[0][convProjects.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvProjectsEN.UpdDate = objDT.Rows[0][convProjects.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvProjectsEN.Memo = objDT.Rows[0][convProjects.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvProjectsDA: GetvProjects)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPrjId">表关键字</param>
 /// <returns>表对象</returns>
public clsvProjectsEN GetObjByPrjId(string strPrjId)
{
CheckPrimaryKey(strPrjId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
strSQL = "Select * from vProjects where PrjId = " + "'"+ strPrjId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
 objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名(字段类型:varchar,字段长度:128,是否可空:True)
 objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名(字段类型:varchar,字段长度:200,是否可空:True)
 objvProjectsEN.IsRelaDataBase = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库(字段类型:bit,字段长度:1,是否可空:True)
 objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID(字段类型:char,字段长度:4,是否可空:False)
 objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvProjectsEN.ApplicationTypeId = Int32.Parse(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
 objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvProjectsEN.IsSupportMvc = clsEntityBase2.TransNullToBool_S(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc(字段类型:bit,字段长度:1,是否可空:True)
 objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvProjectsDA: GetObjByPrjId)", objException.Message));
}
return objvProjectsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvProjectsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvProjectsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
strSQL = "Select * from vProjects where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN()
{
PrjId = objRow[convProjects.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convProjects.PrjName].ToString().Trim(), //工程名称
PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(), //域/包名
IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(), //ISO工程名
JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(), //Java包名
IsRelaDataBase = TransNullToBool(objRow[convProjects.IsRelaDataBase].ToString().Trim()), //是否关联数据库
SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(), //架构ID
SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(), //架构名称
ApplicationTypeId = TransNullToInt(objRow[convProjects.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
UseStateId = objRow[convProjects.UseStateId].ToString().Trim(), //使用状态Id
UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(), //使用状态名称
IsSupportMvc = TransNullToBool(objRow[convProjects.IsSupportMvc].ToString().Trim()), //是否支持Mvc
UserId = objRow[convProjects.UserId].ToString().Trim(), //用户Id
UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim() //说明
};
objvProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProjectsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvProjectsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvProjectsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = TransNullToBool(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = TransNullToInt(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = TransNullToBool(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvProjectsDA: GetObjByDataRowvProjects)", objException.Message));
}
objvProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProjectsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvProjectsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvProjectsEN objvProjectsEN = new clsvProjectsEN();
try
{
objvProjectsEN.PrjId = objRow[convProjects.PrjId].ToString().Trim(); //工程Id
objvProjectsEN.PrjName = objRow[convProjects.PrjName].ToString().Trim(); //工程名称
objvProjectsEN.PrjDomain = objRow[convProjects.PrjDomain] == DBNull.Value ? null : objRow[convProjects.PrjDomain].ToString().Trim(); //域/包名
objvProjectsEN.IsoPrjName = objRow[convProjects.IsoPrjName] == DBNull.Value ? null : objRow[convProjects.IsoPrjName].ToString().Trim(); //ISO工程名
objvProjectsEN.JavaPackageName = objRow[convProjects.JavaPackageName] == DBNull.Value ? null : objRow[convProjects.JavaPackageName].ToString().Trim(); //Java包名
objvProjectsEN.IsRelaDataBase = TransNullToBool(objRow[convProjects.IsRelaDataBase].ToString().Trim()); //是否关联数据库
objvProjectsEN.SoftStructureId = objRow[convProjects.SoftStructureId].ToString().Trim(); //架构ID
objvProjectsEN.SoftStructureName = objRow[convProjects.SoftStructureName] == DBNull.Value ? null : objRow[convProjects.SoftStructureName].ToString().Trim(); //架构名称
objvProjectsEN.ApplicationTypeId = TransNullToInt(objRow[convProjects.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvProjectsEN.ApplicationTypeName = objRow[convProjects.ApplicationTypeName] == DBNull.Value ? null : objRow[convProjects.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvProjectsEN.UseStateId = objRow[convProjects.UseStateId].ToString().Trim(); //使用状态Id
objvProjectsEN.UseStateName = objRow[convProjects.UseStateName] == DBNull.Value ? null : objRow[convProjects.UseStateName].ToString().Trim(); //使用状态名称
objvProjectsEN.IsSupportMvc = TransNullToBool(objRow[convProjects.IsSupportMvc].ToString().Trim()); //是否支持Mvc
objvProjectsEN.UserId = objRow[convProjects.UserId].ToString().Trim(); //用户Id
objvProjectsEN.UpdDate = objRow[convProjects.UpdDate] == DBNull.Value ? null : objRow[convProjects.UpdDate].ToString().Trim(); //修改日期
objvProjectsEN.Memo = objRow[convProjects.Memo] == DBNull.Value ? null : objRow[convProjects.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvProjectsDA: GetObjByDataRow)", objException.Message));
}
objvProjectsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvProjectsEN;
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
objSQL = clsvProjectsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvProjectsEN._CurrTabName, convProjects.PrjId, 4, "");
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
objSQL = clsvProjectsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvProjectsEN._CurrTabName, convProjects.PrjId, 4, strPrefix);
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
 objSQL = clsvProjectsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PrjId from vProjects where " + strCondition;
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
 objSQL = clsvProjectsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PrjId from vProjects where " + strCondition;
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
 objSQL = clsvProjectsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vProjects", "PrjId = " + "'"+ strPrjId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvProjectsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvProjectsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vProjects", strCondition))
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
objSQL = clsvProjectsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vProjects");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvProjectsENS">源对象</param>
 /// <param name = "objvProjectsENT">目标对象</param>
public void CopyTo(clsvProjectsEN objvProjectsENS, clsvProjectsEN objvProjectsENT)
{
objvProjectsENT.PrjId = objvProjectsENS.PrjId; //工程Id
objvProjectsENT.PrjName = objvProjectsENS.PrjName; //工程名称
objvProjectsENT.PrjDomain = objvProjectsENS.PrjDomain; //域/包名
objvProjectsENT.IsoPrjName = objvProjectsENS.IsoPrjName; //ISO工程名
objvProjectsENT.JavaPackageName = objvProjectsENS.JavaPackageName; //Java包名
objvProjectsENT.IsRelaDataBase = objvProjectsENS.IsRelaDataBase; //是否关联数据库
objvProjectsENT.SoftStructureId = objvProjectsENS.SoftStructureId; //架构ID
objvProjectsENT.SoftStructureName = objvProjectsENS.SoftStructureName; //架构名称
objvProjectsENT.ApplicationTypeId = objvProjectsENS.ApplicationTypeId; //应用程序类型ID
objvProjectsENT.ApplicationTypeName = objvProjectsENS.ApplicationTypeName; //应用程序类型名称
objvProjectsENT.UseStateId = objvProjectsENS.UseStateId; //使用状态Id
objvProjectsENT.UseStateName = objvProjectsENS.UseStateName; //使用状态名称
objvProjectsENT.IsSupportMvc = objvProjectsENS.IsSupportMvc; //是否支持Mvc
objvProjectsENT.UserId = objvProjectsENS.UserId; //用户Id
objvProjectsENT.UpdDate = objvProjectsENS.UpdDate; //修改日期
objvProjectsENT.Memo = objvProjectsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvProjectsEN objvProjectsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvProjectsEN.PrjId, 4, convProjects.PrjId);
clsCheckSql.CheckFieldLen(objvProjectsEN.PrjName, 30, convProjects.PrjName);
clsCheckSql.CheckFieldLen(objvProjectsEN.PrjDomain, 128, convProjects.PrjDomain);
clsCheckSql.CheckFieldLen(objvProjectsEN.IsoPrjName, 50, convProjects.IsoPrjName);
clsCheckSql.CheckFieldLen(objvProjectsEN.JavaPackageName, 200, convProjects.JavaPackageName);
clsCheckSql.CheckFieldLen(objvProjectsEN.SoftStructureId, 4, convProjects.SoftStructureId);
clsCheckSql.CheckFieldLen(objvProjectsEN.SoftStructureName, 50, convProjects.SoftStructureName);
clsCheckSql.CheckFieldLen(objvProjectsEN.ApplicationTypeName, 30, convProjects.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvProjectsEN.UseStateId, 4, convProjects.UseStateId);
clsCheckSql.CheckFieldLen(objvProjectsEN.UseStateName, 30, convProjects.UseStateName);
clsCheckSql.CheckFieldLen(objvProjectsEN.UserId, 18, convProjects.UserId);
clsCheckSql.CheckFieldLen(objvProjectsEN.UpdDate, 20, convProjects.UpdDate);
clsCheckSql.CheckFieldLen(objvProjectsEN.Memo, 1000, convProjects.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.PrjId, convProjects.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.PrjName, convProjects.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.PrjDomain, convProjects.PrjDomain);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.IsoPrjName, convProjects.IsoPrjName);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.JavaPackageName, convProjects.JavaPackageName);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.SoftStructureId, convProjects.SoftStructureId);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.SoftStructureName, convProjects.SoftStructureName);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.ApplicationTypeName, convProjects.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.UseStateId, convProjects.UseStateId);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.UseStateName, convProjects.UseStateName);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.UserId, convProjects.UserId);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.UpdDate, convProjects.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvProjectsEN.Memo, convProjects.Memo);
//检查外键字段长度
 objvProjectsEN._IsCheckProperty = true;
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
 objSQL = clsvProjectsDA.GetSpecSQLObj();
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
 objSQL = clsvProjectsDA.GetSpecSQLObj();
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
 objSQL = clsvProjectsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvProjectsEN._CurrTabName);
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
 objSQL = clsvProjectsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvProjectsEN._CurrTabName, strCondition);
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
 objSQL = clsvProjectsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}