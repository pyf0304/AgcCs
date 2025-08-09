
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserCodePrjMainPathDA
 表名:vUserCodePrjMainPath(00050339)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:32
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
 /// v用户生成项目主路径(vUserCodePrjMainPath)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUserCodePrjMainPathDA : clsCommBase4DA
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
 return clsvUserCodePrjMainPathEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUserCodePrjMainPathEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserCodePrjMainPathEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUserCodePrjMainPathEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUserCodePrjMainPathEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strUserCodePrjMainPathId)
{
strUserCodePrjMainPathId = strUserCodePrjMainPathId.Replace("'", "''");
if (strUserCodePrjMainPathId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vUserCodePrjMainPath中,检查关键字,长度不正确!(clsvUserCodePrjMainPathDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strUserCodePrjMainPathId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vUserCodePrjMainPath中,关键字不能为空 或 null!(clsvUserCodePrjMainPathDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strUserCodePrjMainPathId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvUserCodePrjMainPathDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePrjMainPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUserCodePrjMainPath(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTable_vUserCodePrjMainPath)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePrjMainPath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePrjMainPath where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePrjMainPath where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePrjMainPath where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUserCodePrjMainPath where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUserCodePrjMainPath.* " + 
$"from vUserCodePrjMainPath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUserCodePrjMainPath.UserCodePrjMainPathId not in " + 
$"(Select top {intTop_In} vUserCodePrjMainPath.UserCodePrjMainPathId from vUserCodePrjMainPath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePrjMainPath where {1} and UserCodePrjMainPathId not in (Select top {2} UserCodePrjMainPathId from vUserCodePrjMainPath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePrjMainPath where {1} and UserCodePrjMainPathId not in (Select top {3} UserCodePrjMainPathId from vUserCodePrjMainPath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUserCodePrjMainPath.* " + 
$"from vUserCodePrjMainPath " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUserCodePrjMainPath.UserCodePrjMainPathId not in " + 
$"(Select top {intTop_In} vUserCodePrjMainPath.UserCodePrjMainPathId from vUserCodePrjMainPath " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePrjMainPath where {1} and UserCodePrjMainPathId not in (Select top {2} UserCodePrjMainPathId from vUserCodePrjMainPath where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserCodePrjMainPath where {1} and UserCodePrjMainPathId not in (Select top {3} UserCodePrjMainPathId from vUserCodePrjMainPath where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUserCodePrjMainPathEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA:GetObjLst)", objException.Message));
}
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePrjMainPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = TransNullToBool(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = TransNullToInt(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = TransNullToBool(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserCodePrjMainPathDA: GetObjLst)", objException.Message));
}
objvUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserCodePrjMainPathEN);
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
public List<clsvUserCodePrjMainPathEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUserCodePrjMainPathEN> arrObjLst = new List<clsvUserCodePrjMainPathEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = TransNullToBool(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = TransNullToInt(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = TransNullToBool(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserCodePrjMainPathDA: GetObjLst)", objException.Message));
}
objvUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserCodePrjMainPathEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUserCodePrjMainPath(ref clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePrjMainPath where UserCodePrjMainPathId = " + "'"+ objvUserCodePrjMainPathEN.UserCodePrjMainPathId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUserCodePrjMainPathEN.ApplicationTypeENName = objDT.Rows[0][convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objDT.Rows[0][convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id(字段类型:char,字段长度:8,是否可空:False)
 objvUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objDT.Rows[0][convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserCodePrjMainPathEN.PrjId = objDT.Rows[0][convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvUserCodePrjMainPathEN.PrjName = objDT.Rows[0][convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.ProgLangTypeId = objDT.Rows[0][convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvUserCodePrjMainPathEN.UserId = objDT.Rows[0][convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserCodePrjMainPathEN.UserName = objDT.Rows[0][convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.DepartmentId = objDT.Rows[0][convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvUserCodePrjMainPathEN.DepartmentName = objDT.Rows[0][convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.UserStateId = objDT.Rows[0][convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号(字段类型:char,字段长度:2,是否可空:True)
 objvUserCodePrjMainPathEN.UserStateName = objDT.Rows[0][convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objDT.Rows[0][convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径(字段类型:bit,字段长度:1,是否可空:False)
 objvUserCodePrjMainPathEN.IncludeXmlPath = objDT.Rows[0][convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径(字段类型:varchar,字段长度:150,是否可空:True)
 objvUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objDT.Rows[0][convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvUserCodePrjMainPathEN.InUse = TransNullToBool(objDT.Rows[0][convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePrjMainPathEN.UpdDate = objDT.Rows[0][convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserCodePrjMainPathEN.UpdUserId = objDT.Rows[0][convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserCodePrjMainPathEN.Memo = objDT.Rows[0][convUserCodePrjMainPath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvUserCodePrjMainPathEN.ApplicationTypeSimName = objDT.Rows[0][convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserCodePrjMainPathEN.CmPrjName = objDT.Rows[0][convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserCodePrjMainPathEN.ApplicationTypeName = objDT.Rows[0][convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvUserCodePrjMainPathEN.CmPrjId = objDT.Rows[0][convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvUserCodePrjMainPathEN.AppOrderNum = TransNullToInt(objDT.Rows[0][convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvUserCodePrjMainPathEN.AppIsVisible = TransNullToBool(objDT.Rows[0][convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUserCodePrjMainPathDA: GetvUserCodePrjMainPath)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strUserCodePrjMainPathId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUserCodePrjMainPathEN GetObjByUserCodePrjMainPathId(string strUserCodePrjMainPathId)
{
CheckPrimaryKey(strUserCodePrjMainPathId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePrjMainPath where UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
 objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id(字段类型:char,字段长度:8,是否可空:False)
 objvUserCodePrjMainPathEN.CMProjectAppRelaId = Int32.Parse(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号(字段类型:char,字段长度:2,是否可空:True)
 objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvUserCodePrjMainPathEN.IsUsePrjMainPath = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径(字段类型:bit,字段长度:1,是否可空:False)
 objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径(字段类型:varchar,字段长度:150,是否可空:True)
 objvUserCodePrjMainPathEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvUserCodePrjMainPathEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserCodePrjMainPathEN.ApplicationTypeId = Int32.Parse(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvUserCodePrjMainPathEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUserCodePrjMainPathDA: GetObjByUserCodePrjMainPathId)", objException.Message));
}
return objvUserCodePrjMainPathEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUserCodePrjMainPathEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
strSQL = "Select * from vUserCodePrjMainPath where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN()
{
ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(), //生成主目录Id
CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()), //Cm工程应用关系Id
PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(), //工程名称
ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(), //用户Id
UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(), //用户名
DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(), //部门ID
DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(), //部门名称
UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(), //用户状态号
UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(), //用户状态名
IsUsePrjMainPath = TransNullToBool(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()), //是否使用主路径
IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(), //包含表Xml路径
IsTemplate = TransNullToBool(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()), //是否模板
InUse = TransNullToBool(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()), //是否在用
UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(), //说明
ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(), //CM工程名
ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeId = TransNullToInt(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(), //Cm工程Id
AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()), //AppOrderNum
AppIsVisible = TransNullToBool(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()) //AppIsVisible
};
objvUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserCodePrjMainPathEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUserCodePrjMainPathDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUserCodePrjMainPathEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = TransNullToBool(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = TransNullToInt(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = TransNullToBool(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUserCodePrjMainPathDA: GetObjByDataRowvUserCodePrjMainPath)", objException.Message));
}
objvUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserCodePrjMainPathEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUserCodePrjMainPathEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN = new clsvUserCodePrjMainPathEN();
try
{
objvUserCodePrjMainPathEN.ApplicationTypeENName = objRow[convUserCodePrjMainPath.ApplicationTypeENName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvUserCodePrjMainPathEN.UserCodePrjMainPathId = objRow[convUserCodePrjMainPath.UserCodePrjMainPathId].ToString().Trim(); //生成主目录Id
objvUserCodePrjMainPathEN.CMProjectAppRelaId = TransNullToInt(objRow[convUserCodePrjMainPath.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvUserCodePrjMainPathEN.PrjId = objRow[convUserCodePrjMainPath.PrjId].ToString().Trim(); //工程Id
objvUserCodePrjMainPathEN.PrjName = objRow[convUserCodePrjMainPath.PrjName].ToString().Trim(); //工程名称
objvUserCodePrjMainPathEN.ProgLangTypeId = objRow[convUserCodePrjMainPath.ProgLangTypeId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvUserCodePrjMainPathEN.UserId = objRow[convUserCodePrjMainPath.UserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserId].ToString().Trim(); //用户Id
objvUserCodePrjMainPathEN.UserName = objRow[convUserCodePrjMainPath.UserName].ToString().Trim(); //用户名
objvUserCodePrjMainPathEN.DepartmentId = objRow[convUserCodePrjMainPath.DepartmentId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.DepartmentId].ToString().Trim(); //部门ID
objvUserCodePrjMainPathEN.DepartmentName = objRow[convUserCodePrjMainPath.DepartmentName].ToString().Trim(); //部门名称
objvUserCodePrjMainPathEN.UserStateId = objRow[convUserCodePrjMainPath.UserStateId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UserStateId].ToString().Trim(); //用户状态号
objvUserCodePrjMainPathEN.UserStateName = objRow[convUserCodePrjMainPath.UserStateName].ToString().Trim(); //用户状态名
objvUserCodePrjMainPathEN.IsUsePrjMainPath = TransNullToBool(objRow[convUserCodePrjMainPath.IsUsePrjMainPath].ToString().Trim()); //是否使用主路径
objvUserCodePrjMainPathEN.IncludeXmlPath = objRow[convUserCodePrjMainPath.IncludeXmlPath] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.IncludeXmlPath].ToString().Trim(); //包含表Xml路径
objvUserCodePrjMainPathEN.IsTemplate = TransNullToBool(objRow[convUserCodePrjMainPath.IsTemplate].ToString().Trim()); //是否模板
objvUserCodePrjMainPathEN.InUse = TransNullToBool(objRow[convUserCodePrjMainPath.InUse].ToString().Trim()); //是否在用
objvUserCodePrjMainPathEN.UpdDate = objRow[convUserCodePrjMainPath.UpdDate] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdDate].ToString().Trim(); //修改日期
objvUserCodePrjMainPathEN.UpdUserId = objRow[convUserCodePrjMainPath.UpdUserId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.UpdUserId].ToString().Trim(); //修改用户Id
objvUserCodePrjMainPathEN.Memo = objRow[convUserCodePrjMainPath.Memo] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.Memo].ToString().Trim(); //说明
objvUserCodePrjMainPathEN.ApplicationTypeSimName = objRow[convUserCodePrjMainPath.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvUserCodePrjMainPathEN.CmPrjName = objRow[convUserCodePrjMainPath.CmPrjName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjName].ToString().Trim(); //CM工程名
objvUserCodePrjMainPathEN.ApplicationTypeName = objRow[convUserCodePrjMainPath.ApplicationTypeName] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvUserCodePrjMainPathEN.ApplicationTypeId = TransNullToInt(objRow[convUserCodePrjMainPath.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvUserCodePrjMainPathEN.CmPrjId = objRow[convUserCodePrjMainPath.CmPrjId] == DBNull.Value ? null : objRow[convUserCodePrjMainPath.CmPrjId].ToString().Trim(); //Cm工程Id
objvUserCodePrjMainPathEN.AppOrderNum = objRow[convUserCodePrjMainPath.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserCodePrjMainPath.AppOrderNum].ToString().Trim()); //AppOrderNum
objvUserCodePrjMainPathEN.AppIsVisible = TransNullToBool(objRow[convUserCodePrjMainPath.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUserCodePrjMainPathDA: GetObjByDataRow)", objException.Message));
}
objvUserCodePrjMainPathEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserCodePrjMainPathEN;
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
objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserCodePrjMainPathEN._CurrTabName, convUserCodePrjMainPath.UserCodePrjMainPathId, 8, "");
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
objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserCodePrjMainPathEN._CurrTabName, convUserCodePrjMainPath.UserCodePrjMainPathId, 8, strPrefix);
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
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select UserCodePrjMainPathId from vUserCodePrjMainPath where " + strCondition;
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
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select UserCodePrjMainPathId from vUserCodePrjMainPath where " + strCondition;
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
 /// <param name = "strUserCodePrjMainPathId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strUserCodePrjMainPathId)
{
CheckPrimaryKey(strUserCodePrjMainPathId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserCodePrjMainPath", "UserCodePrjMainPathId = " + "'"+ strUserCodePrjMainPathId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUserCodePrjMainPathDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserCodePrjMainPath", strCondition))
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
objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUserCodePrjMainPath");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUserCodePrjMainPathENS">源对象</param>
 /// <param name = "objvUserCodePrjMainPathENT">目标对象</param>
public void CopyTo(clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENS, clsvUserCodePrjMainPathEN objvUserCodePrjMainPathENT)
{
objvUserCodePrjMainPathENT.ApplicationTypeENName = objvUserCodePrjMainPathENS.ApplicationTypeENName; //应用类型英文名
objvUserCodePrjMainPathENT.UserCodePrjMainPathId = objvUserCodePrjMainPathENS.UserCodePrjMainPathId; //生成主目录Id
objvUserCodePrjMainPathENT.CMProjectAppRelaId = objvUserCodePrjMainPathENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvUserCodePrjMainPathENT.PrjId = objvUserCodePrjMainPathENS.PrjId; //工程Id
objvUserCodePrjMainPathENT.PrjName = objvUserCodePrjMainPathENS.PrjName; //工程名称
objvUserCodePrjMainPathENT.ProgLangTypeId = objvUserCodePrjMainPathENS.ProgLangTypeId; //编程语言类型Id
objvUserCodePrjMainPathENT.UserId = objvUserCodePrjMainPathENS.UserId; //用户Id
objvUserCodePrjMainPathENT.UserName = objvUserCodePrjMainPathENS.UserName; //用户名
objvUserCodePrjMainPathENT.DepartmentId = objvUserCodePrjMainPathENS.DepartmentId; //部门ID
objvUserCodePrjMainPathENT.DepartmentName = objvUserCodePrjMainPathENS.DepartmentName; //部门名称
objvUserCodePrjMainPathENT.UserStateId = objvUserCodePrjMainPathENS.UserStateId; //用户状态号
objvUserCodePrjMainPathENT.UserStateName = objvUserCodePrjMainPathENS.UserStateName; //用户状态名
objvUserCodePrjMainPathENT.IsUsePrjMainPath = objvUserCodePrjMainPathENS.IsUsePrjMainPath; //是否使用主路径
objvUserCodePrjMainPathENT.IncludeXmlPath = objvUserCodePrjMainPathENS.IncludeXmlPath; //包含表Xml路径
objvUserCodePrjMainPathENT.IsTemplate = objvUserCodePrjMainPathENS.IsTemplate; //是否模板
objvUserCodePrjMainPathENT.InUse = objvUserCodePrjMainPathENS.InUse; //是否在用
objvUserCodePrjMainPathENT.UpdDate = objvUserCodePrjMainPathENS.UpdDate; //修改日期
objvUserCodePrjMainPathENT.UpdUserId = objvUserCodePrjMainPathENS.UpdUserId; //修改用户Id
objvUserCodePrjMainPathENT.Memo = objvUserCodePrjMainPathENS.Memo; //说明
objvUserCodePrjMainPathENT.ApplicationTypeSimName = objvUserCodePrjMainPathENS.ApplicationTypeSimName; //应用程序类型简称
objvUserCodePrjMainPathENT.CmPrjName = objvUserCodePrjMainPathENS.CmPrjName; //CM工程名
objvUserCodePrjMainPathENT.ApplicationTypeName = objvUserCodePrjMainPathENS.ApplicationTypeName; //应用程序类型名称
objvUserCodePrjMainPathENT.ApplicationTypeId = objvUserCodePrjMainPathENS.ApplicationTypeId; //应用程序类型ID
objvUserCodePrjMainPathENT.CmPrjId = objvUserCodePrjMainPathENS.CmPrjId; //Cm工程Id
objvUserCodePrjMainPathENT.AppOrderNum = objvUserCodePrjMainPathENS.AppOrderNum; //AppOrderNum
objvUserCodePrjMainPathENT.AppIsVisible = objvUserCodePrjMainPathENS.AppIsVisible; //AppIsVisible
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUserCodePrjMainPathEN objvUserCodePrjMainPathEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.ApplicationTypeENName, 30, convUserCodePrjMainPath.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.UserCodePrjMainPathId, 8, convUserCodePrjMainPath.UserCodePrjMainPathId);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.PrjId, 4, convUserCodePrjMainPath.PrjId);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.PrjName, 30, convUserCodePrjMainPath.PrjName);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.ProgLangTypeId, 2, convUserCodePrjMainPath.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.UserId, 18, convUserCodePrjMainPath.UserId);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.UserName, 30, convUserCodePrjMainPath.UserName);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.DepartmentId, 6, convUserCodePrjMainPath.DepartmentId);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.DepartmentName, 30, convUserCodePrjMainPath.DepartmentName);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.UserStateId, 2, convUserCodePrjMainPath.UserStateId);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.UserStateName, 20, convUserCodePrjMainPath.UserStateName);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.IncludeXmlPath, 150, convUserCodePrjMainPath.IncludeXmlPath);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.UpdDate, 20, convUserCodePrjMainPath.UpdDate);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.UpdUserId, 20, convUserCodePrjMainPath.UpdUserId);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.Memo, 1000, convUserCodePrjMainPath.Memo);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.ApplicationTypeSimName, 30, convUserCodePrjMainPath.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.CmPrjName, 50, convUserCodePrjMainPath.CmPrjName);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.ApplicationTypeName, 30, convUserCodePrjMainPath.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvUserCodePrjMainPathEN.CmPrjId, 6, convUserCodePrjMainPath.CmPrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.ApplicationTypeENName, convUserCodePrjMainPath.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.UserCodePrjMainPathId, convUserCodePrjMainPath.UserCodePrjMainPathId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.PrjId, convUserCodePrjMainPath.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.PrjName, convUserCodePrjMainPath.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.ProgLangTypeId, convUserCodePrjMainPath.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.UserId, convUserCodePrjMainPath.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.UserName, convUserCodePrjMainPath.UserName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.DepartmentId, convUserCodePrjMainPath.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.DepartmentName, convUserCodePrjMainPath.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.UserStateId, convUserCodePrjMainPath.UserStateId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.UserStateName, convUserCodePrjMainPath.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.IncludeXmlPath, convUserCodePrjMainPath.IncludeXmlPath);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.UpdDate, convUserCodePrjMainPath.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.UpdUserId, convUserCodePrjMainPath.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.Memo, convUserCodePrjMainPath.Memo);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.ApplicationTypeSimName, convUserCodePrjMainPath.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.CmPrjName, convUserCodePrjMainPath.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.ApplicationTypeName, convUserCodePrjMainPath.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvUserCodePrjMainPathEN.CmPrjId, convUserCodePrjMainPath.CmPrjId);
//检查外键字段长度
 objvUserCodePrjMainPathEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetUserCodePrjMainPathId()
{
//获取某学院所有专业信息
string strSQL = "select UserCodePrjMainPathId, ApplicationTypeName from vUserCodePrjMainPath ";
 clsSpecSQLforSql mySql = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
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
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
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
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
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
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserCodePrjMainPathEN._CurrTabName);
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
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserCodePrjMainPathEN._CurrTabName, strCondition);
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
 objSQL = clsvUserCodePrjMainPathDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}