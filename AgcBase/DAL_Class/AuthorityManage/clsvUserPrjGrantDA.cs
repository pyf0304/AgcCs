
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserPrjGrantDA
 表名:vUserPrjGrant(00050174)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:05:36
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:权限管理(AuthorityManage)
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
 /// vUserPrjGrant(vUserPrjGrant)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUserPrjGrantDA : clsCommBase4DA
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
 return clsvUserPrjGrantEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUserPrjGrantEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserPrjGrantEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUserPrjGrantEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUserPrjGrantEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from vUserPrjGrant where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUserPrjGrant(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTable_vUserPrjGrant)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from vUserPrjGrant where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from vUserPrjGrant where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserPrjGrant where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserPrjGrant where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUserPrjGrant where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUserPrjGrant.* " + 
$"from vUserPrjGrant " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUserPrjGrant.mId not in " + 
$"(Select top {intTop_In} vUserPrjGrant.mId from vUserPrjGrant " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserPrjGrant where {1} and mId not in (Select top {2} mId from vUserPrjGrant where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserPrjGrant where {1} and mId not in (Select top {3} mId from vUserPrjGrant where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vUserPrjGrant.* " + 
$"from vUserPrjGrant " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vUserPrjGrant.mId not in " + 
$"(Select top {intTop_In} vUserPrjGrant.mId from vUserPrjGrant " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserPrjGrant where {1} and mId not in (Select top {2} mId from vUserPrjGrant where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserPrjGrant where {1} and mId not in (Select top {3} mId from vUserPrjGrant where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUserPrjGrantEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA:GetObjLst)", objException.Message));
}
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from vUserPrjGrant where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = TransNullToInt(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserPrjGrantDA: GetObjLst)", objException.Message));
}
objvUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserPrjGrantEN);
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
public List<clsvUserPrjGrantEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUserPrjGrantEN> arrObjLst = new List<clsvUserPrjGrantEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = TransNullToInt(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserPrjGrantDA: GetObjLst)", objException.Message));
}
objvUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserPrjGrantEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUserPrjGrantEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUserPrjGrant(ref clsvUserPrjGrantEN objvUserPrjGrantEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from vUserPrjGrant where mId = " + ""+ objvUserPrjGrantEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUserPrjGrantEN.mId = TransNullToInt(objDT.Rows[0][convUserPrjGrant.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserPrjGrantEN.UserId = objDT.Rows[0][convUserPrjGrant.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserPrjGrantEN.UserName = objDT.Rows[0][convUserPrjGrant.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserPrjGrantEN.UserStateName = objDT.Rows[0][convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvUserPrjGrantEN.DepartmentId = objDT.Rows[0][convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvUserPrjGrantEN.DepartmentName = objDT.Rows[0][convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserPrjGrantEN.PrjId = objDT.Rows[0][convUserPrjGrant.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvUserPrjGrantEN.PrjName = objDT.Rows[0][convUserPrjGrant.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserPrjGrantEN.RoleId = objDT.Rows[0][convUserPrjGrant.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objvUserPrjGrantEN.RoleName = objDT.Rows[0][convUserPrjGrant.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserPrjGrantEN.VisitedNum = TransNullToInt(objDT.Rows[0][convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数(字段类型:int,字段长度:4,是否可空:True)
 objvUserPrjGrantEN.LastVisitedDate = objDT.Rows[0][convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserPrjGrantEN.OptId = objDT.Rows[0][convUserPrjGrant.OptId].ToString().Trim(); //操作者Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvUserPrjGrantEN.OptDate = objDT.Rows[0][convUserPrjGrant.OptDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvUserPrjGrantEN.Memo = objDT.Rows[0][convUserPrjGrant.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvUserPrjGrantEN.UseStateId = objDT.Rows[0][convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUserPrjGrantDA: GetvUserPrjGrant)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUserPrjGrantEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from vUserPrjGrant where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
 objvUserPrjGrantEN.mId = Int32.Parse(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名(字段类型:varchar,字段长度:20,是否可空:False)
 objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID(字段类型:varchar,字段长度:6,是否可空:True)
 objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数(字段类型:int,字段长度:4,是否可空:True)
 objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id(字段类型:varchar,字段长度:18,是否可空:False)
 objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:20,是否可空:False)
 objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id(字段类型:char,字段长度:4,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUserPrjGrantDA: GetObjBymId)", objException.Message));
}
return objvUserPrjGrantEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUserPrjGrantEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from vUserPrjGrant where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN()
{
mId = TransNullToInt(objRow[convUserPrjGrant.mId].ToString().Trim()), //mId
UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(), //用户Id
UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(), //用户名
UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(), //用户状态名
DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(), //部门ID
DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(), //部门名称
PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(), //工程名称
RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(), //角色ID
RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(), //角色名称
VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()), //访问数
LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(), //最后访问时间
OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(), //操作者Id
OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(), //操作日期
Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(), //说明
UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim() //使用状态Id
};
objvUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserPrjGrantEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUserPrjGrantDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUserPrjGrantEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = TransNullToInt(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUserPrjGrantDA: GetObjByDataRowvUserPrjGrant)", objException.Message));
}
objvUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserPrjGrantEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUserPrjGrantEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserPrjGrantEN objvUserPrjGrantEN = new clsvUserPrjGrantEN();
try
{
objvUserPrjGrantEN.mId = TransNullToInt(objRow[convUserPrjGrant.mId].ToString().Trim()); //mId
objvUserPrjGrantEN.UserId = objRow[convUserPrjGrant.UserId].ToString().Trim(); //用户Id
objvUserPrjGrantEN.UserName = objRow[convUserPrjGrant.UserName].ToString().Trim(); //用户名
objvUserPrjGrantEN.UserStateName = objRow[convUserPrjGrant.UserStateName] == DBNull.Value ? null : objRow[convUserPrjGrant.UserStateName].ToString().Trim(); //用户状态名
objvUserPrjGrantEN.DepartmentId = objRow[convUserPrjGrant.DepartmentId] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentId].ToString().Trim(); //部门ID
objvUserPrjGrantEN.DepartmentName = objRow[convUserPrjGrant.DepartmentName] == DBNull.Value ? null : objRow[convUserPrjGrant.DepartmentName].ToString().Trim(); //部门名称
objvUserPrjGrantEN.PrjId = objRow[convUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objvUserPrjGrantEN.PrjName = objRow[convUserPrjGrant.PrjName].ToString().Trim(); //工程名称
objvUserPrjGrantEN.RoleId = objRow[convUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objvUserPrjGrantEN.RoleName = objRow[convUserPrjGrant.RoleName].ToString().Trim(); //角色名称
objvUserPrjGrantEN.VisitedNum = objRow[convUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objvUserPrjGrantEN.LastVisitedDate = objRow[convUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[convUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objvUserPrjGrantEN.OptId = objRow[convUserPrjGrant.OptId] == DBNull.Value ? null : objRow[convUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objvUserPrjGrantEN.OptDate = objRow[convUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[convUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objvUserPrjGrantEN.Memo = objRow[convUserPrjGrant.Memo] == DBNull.Value ? null : objRow[convUserPrjGrant.Memo].ToString().Trim(); //说明
objvUserPrjGrantEN.UseStateId = objRow[convUserPrjGrant.UseStateId] == DBNull.Value ? null : objRow[convUserPrjGrant.UseStateId].ToString().Trim(); //使用状态Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUserPrjGrantDA: GetObjByDataRow)", objException.Message));
}
objvUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserPrjGrantEN;
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
objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserPrjGrantEN._CurrTabName, convUserPrjGrant.mId, 8, "");
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
objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserPrjGrantEN._CurrTabName, convUserPrjGrant.mId, 8, strPrefix);
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
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vUserPrjGrant where " + strCondition;
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
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vUserPrjGrant where " + strCondition;
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
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserPrjGrant", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUserPrjGrantDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserPrjGrant", strCondition))
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
objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUserPrjGrant");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUserPrjGrantENS">源对象</param>
 /// <param name = "objvUserPrjGrantENT">目标对象</param>
public void CopyTo(clsvUserPrjGrantEN objvUserPrjGrantENS, clsvUserPrjGrantEN objvUserPrjGrantENT)
{
objvUserPrjGrantENT.mId = objvUserPrjGrantENS.mId; //mId
objvUserPrjGrantENT.UserId = objvUserPrjGrantENS.UserId; //用户Id
objvUserPrjGrantENT.UserName = objvUserPrjGrantENS.UserName; //用户名
objvUserPrjGrantENT.UserStateName = objvUserPrjGrantENS.UserStateName; //用户状态名
objvUserPrjGrantENT.DepartmentId = objvUserPrjGrantENS.DepartmentId; //部门ID
objvUserPrjGrantENT.DepartmentName = objvUserPrjGrantENS.DepartmentName; //部门名称
objvUserPrjGrantENT.PrjId = objvUserPrjGrantENS.PrjId; //工程Id
objvUserPrjGrantENT.PrjName = objvUserPrjGrantENS.PrjName; //工程名称
objvUserPrjGrantENT.RoleId = objvUserPrjGrantENS.RoleId; //角色ID
objvUserPrjGrantENT.RoleName = objvUserPrjGrantENS.RoleName; //角色名称
objvUserPrjGrantENT.VisitedNum = objvUserPrjGrantENS.VisitedNum; //访问数
objvUserPrjGrantENT.LastVisitedDate = objvUserPrjGrantENS.LastVisitedDate; //最后访问时间
objvUserPrjGrantENT.OptId = objvUserPrjGrantENS.OptId; //操作者Id
objvUserPrjGrantENT.OptDate = objvUserPrjGrantENS.OptDate; //操作日期
objvUserPrjGrantENT.Memo = objvUserPrjGrantENS.Memo; //说明
objvUserPrjGrantENT.UseStateId = objvUserPrjGrantENS.UseStateId; //使用状态Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUserPrjGrantEN objvUserPrjGrantEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.UserId, 18, convUserPrjGrant.UserId);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.UserName, 30, convUserPrjGrant.UserName);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.UserStateName, 20, convUserPrjGrant.UserStateName);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.DepartmentId, 6, convUserPrjGrant.DepartmentId);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.DepartmentName, 30, convUserPrjGrant.DepartmentName);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.PrjId, 4, convUserPrjGrant.PrjId);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.PrjName, 30, convUserPrjGrant.PrjName);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.RoleId, 8, convUserPrjGrant.RoleId);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.RoleName, 30, convUserPrjGrant.RoleName);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.LastVisitedDate, 20, convUserPrjGrant.LastVisitedDate);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.OptId, 18, convUserPrjGrant.OptId);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.OptDate, 20, convUserPrjGrant.OptDate);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.Memo, 1000, convUserPrjGrant.Memo);
clsCheckSql.CheckFieldLen(objvUserPrjGrantEN.UseStateId, 4, convUserPrjGrant.UseStateId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.UserId, convUserPrjGrant.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.UserName, convUserPrjGrant.UserName);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.UserStateName, convUserPrjGrant.UserStateName);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.DepartmentId, convUserPrjGrant.DepartmentId);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.DepartmentName, convUserPrjGrant.DepartmentName);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.PrjId, convUserPrjGrant.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.PrjName, convUserPrjGrant.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.RoleId, convUserPrjGrant.RoleId);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.RoleName, convUserPrjGrant.RoleName);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.LastVisitedDate, convUserPrjGrant.LastVisitedDate);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.OptId, convUserPrjGrant.OptId);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.OptDate, convUserPrjGrant.OptDate);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.Memo, convUserPrjGrant.Memo);
clsCheckSql.CheckSqlInjection4Field(objvUserPrjGrantEN.UseStateId, convUserPrjGrant.UseStateId);
//检查外键字段长度
 objvUserPrjGrantEN._IsCheckProperty = true;
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
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
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
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
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
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserPrjGrantEN._CurrTabName);
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
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserPrjGrantEN._CurrTabName, strCondition);
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
 objSQL = clsvUserPrjGrantDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}