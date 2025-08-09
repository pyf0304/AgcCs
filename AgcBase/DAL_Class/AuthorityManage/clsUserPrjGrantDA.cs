
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUserPrjGrantDA
 表名:UserPrjGrant(00050092)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:06:52
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
 /// UserPrjGrant(UserPrjGrant)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUserPrjGrantDA : clsCommBase4DA
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
 return clsUserPrjGrantEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUserPrjGrantEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUserPrjGrantEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUserPrjGrantEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUserPrjGrantEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UserPrjGrant(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTable_UserPrjGrant)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserPrjGrant where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserPrjGrant where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UserPrjGrant where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserPrjGrant.* " + 
$"from UserPrjGrant " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserPrjGrant.mId not in " + 
$"(Select top {intTop_In} UserPrjGrant.mId from UserPrjGrant " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserPrjGrant where {1} and mId not in (Select top {2} mId from UserPrjGrant where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserPrjGrant where {1} and mId not in (Select top {3} mId from UserPrjGrant where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UserPrjGrant.* " + 
$"from UserPrjGrant " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UserPrjGrant.mId not in " + 
$"(Select top {intTop_In} UserPrjGrant.mId from UserPrjGrant " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UserPrjGrant where {1} and mId not in (Select top {2} mId from UserPrjGrant where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UserPrjGrant where {1} and mId not in (Select top {3} mId from UserPrjGrant where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUserPrjGrantEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUserPrjGrantDA:GetObjLst)", objException.Message));
}
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = TransNullToInt(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserPrjGrantDA: GetObjLst)", objException.Message));
}
objUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserPrjGrantEN);
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
public List<clsUserPrjGrantEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUserPrjGrantDA:GetObjLstByTabName)", objException.Message));
}
List<clsUserPrjGrantEN> arrObjLst = new List<clsUserPrjGrantEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = TransNullToInt(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUserPrjGrantDA: GetObjLst)", objException.Message));
}
objUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUserPrjGrantEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUserPrjGrant(ref clsUserPrjGrantEN objUserPrjGrantEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where mId = " + ""+ objUserPrjGrantEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUserPrjGrantEN.mId = TransNullToInt(objDT.Rows[0][conUserPrjGrant.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserPrjGrantEN.UserId = objDT.Rows[0][conUserPrjGrant.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserPrjGrantEN.PrjId = objDT.Rows[0][conUserPrjGrant.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUserPrjGrantEN.RoleId = objDT.Rows[0][conUserPrjGrant.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objUserPrjGrantEN.VisitedNum = TransNullToInt(objDT.Rows[0][conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数(字段类型:int,字段长度:4,是否可空:True)
 objUserPrjGrantEN.LastVisitedDate = objDT.Rows[0][conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间(字段类型:varchar,字段长度:20,是否可空:True)
 objUserPrjGrantEN.OptId = objDT.Rows[0][conUserPrjGrant.OptId].ToString().Trim(); //操作者Id(字段类型:varchar,字段长度:18,是否可空:False)
 objUserPrjGrantEN.OptDate = objDT.Rows[0][conUserPrjGrant.OptDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:20,是否可空:False)
 objUserPrjGrantEN.Memo = objDT.Rows[0][conUserPrjGrant.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUserPrjGrantDA: GetUserPrjGrant)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsUserPrjGrantEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
 objUserPrjGrantEN.mId = Int32.Parse(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID(字段类型:char,字段长度:8,是否可空:True)
 objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数(字段类型:int,字段长度:4,是否可空:True)
 objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间(字段类型:varchar,字段长度:20,是否可空:True)
 objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id(字段类型:varchar,字段长度:18,是否可空:False)
 objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期(字段类型:varchar,字段长度:20,是否可空:False)
 objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUserPrjGrantDA: GetObjBymId)", objException.Message));
}
return objUserPrjGrantEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUserPrjGrantEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN()
{
mId = TransNullToInt(objRow[conUserPrjGrant.mId].ToString().Trim()), //mId
UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(), //用户Id
PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(), //工程Id
RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(), //角色ID
VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()), //访问数
LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(), //最后访问时间
OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(), //操作者Id
OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(), //操作日期
Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim() //说明
};
objUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserPrjGrantEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUserPrjGrantDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUserPrjGrantEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = TransNullToInt(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUserPrjGrantDA: GetObjByDataRowUserPrjGrant)", objException.Message));
}
objUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserPrjGrantEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUserPrjGrantEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUserPrjGrantEN objUserPrjGrantEN = new clsUserPrjGrantEN();
try
{
objUserPrjGrantEN.mId = TransNullToInt(objRow[conUserPrjGrant.mId].ToString().Trim()); //mId
objUserPrjGrantEN.UserId = objRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objUserPrjGrantEN.PrjId = objRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objUserPrjGrantEN.RoleId = objRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objUserPrjGrantEN.VisitedNum = objRow[conUserPrjGrant.VisitedNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUserPrjGrant.VisitedNum].ToString().Trim()); //访问数
objUserPrjGrantEN.LastVisitedDate = objRow[conUserPrjGrant.LastVisitedDate] == DBNull.Value ? null : objRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objUserPrjGrantEN.OptId = objRow[conUserPrjGrant.OptId] == DBNull.Value ? null : objRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objUserPrjGrantEN.OptDate = objRow[conUserPrjGrant.OptDate] == DBNull.Value ? null : objRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objUserPrjGrantEN.Memo = objRow[conUserPrjGrant.Memo] == DBNull.Value ? null : objRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUserPrjGrantDA: GetObjByDataRow)", objException.Message));
}
objUserPrjGrantEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUserPrjGrantEN;
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
objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserPrjGrantEN._CurrTabName, conUserPrjGrant.mId, 8, "");
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
objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUserPrjGrantEN._CurrTabName, conUserPrjGrant.mId, 8, strPrefix);
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from UserPrjGrant where " + strCondition;
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from UserPrjGrant where " + strCondition;
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserPrjGrant", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUserPrjGrantDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UserPrjGrant", strCondition))
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
objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UserPrjGrant");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUserPrjGrantEN objUserPrjGrantEN)
 {
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserPrjGrantEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserPrjGrant");
objRow = objDS.Tables["UserPrjGrant"].NewRow();
objRow[conUserPrjGrant.UserId] = objUserPrjGrantEN.UserId; //用户Id
objRow[conUserPrjGrant.PrjId] = objUserPrjGrantEN.PrjId; //工程Id
objRow[conUserPrjGrant.RoleId] = objUserPrjGrantEN.RoleId; //角色ID
objRow[conUserPrjGrant.VisitedNum] = objUserPrjGrantEN.VisitedNum; //访问数
 if (objUserPrjGrantEN.LastVisitedDate !=  "")
 {
objRow[conUserPrjGrant.LastVisitedDate] = objUserPrjGrantEN.LastVisitedDate; //最后访问时间
 }
 if (objUserPrjGrantEN.OptId !=  "")
 {
objRow[conUserPrjGrant.OptId] = objUserPrjGrantEN.OptId; //操作者Id
 }
 if (objUserPrjGrantEN.OptDate !=  "")
 {
objRow[conUserPrjGrant.OptDate] = objUserPrjGrantEN.OptDate; //操作日期
 }
 if (objUserPrjGrantEN.Memo !=  "")
 {
objRow[conUserPrjGrant.Memo] = objUserPrjGrantEN.Memo; //说明
 }
objDS.Tables[clsUserPrjGrantEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUserPrjGrantEN._CurrTabName);
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserPrjGrantEN objUserPrjGrantEN)
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserPrjGrantEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserPrjGrantEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.UserId);
 var strUserId = objUserPrjGrantEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserPrjGrantEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.PrjId);
 var strPrjId = objUserPrjGrantEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserPrjGrantEN.RoleId  ==  "")
 {
 objUserPrjGrantEN.RoleId = null;
 }
 if (objUserPrjGrantEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.RoleId);
 var strRoleId = objUserPrjGrantEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objUserPrjGrantEN.VisitedNum !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.VisitedNum);
 arrValueListForInsert.Add(objUserPrjGrantEN.VisitedNum.ToString());
 }
 
 if (objUserPrjGrantEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.LastVisitedDate);
 var strLastVisitedDate = objUserPrjGrantEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objUserPrjGrantEN.OptId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.OptId);
 var strOptId = objUserPrjGrantEN.OptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptId + "'");
 }
 
 if (objUserPrjGrantEN.OptDate !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.OptDate);
 var strOptDate = objUserPrjGrantEN.OptDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptDate + "'");
 }
 
 if (objUserPrjGrantEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.Memo);
 var strMemo = objUserPrjGrantEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserPrjGrant");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserPrjGrantEN objUserPrjGrantEN)
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserPrjGrantEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserPrjGrantEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.UserId);
 var strUserId = objUserPrjGrantEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserPrjGrantEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.PrjId);
 var strPrjId = objUserPrjGrantEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserPrjGrantEN.RoleId  ==  "")
 {
 objUserPrjGrantEN.RoleId = null;
 }
 if (objUserPrjGrantEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.RoleId);
 var strRoleId = objUserPrjGrantEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objUserPrjGrantEN.VisitedNum !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.VisitedNum);
 arrValueListForInsert.Add(objUserPrjGrantEN.VisitedNum.ToString());
 }
 
 if (objUserPrjGrantEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.LastVisitedDate);
 var strLastVisitedDate = objUserPrjGrantEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objUserPrjGrantEN.OptId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.OptId);
 var strOptId = objUserPrjGrantEN.OptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptId + "'");
 }
 
 if (objUserPrjGrantEN.OptDate !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.OptDate);
 var strOptDate = objUserPrjGrantEN.OptDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptDate + "'");
 }
 
 if (objUserPrjGrantEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.Memo);
 var strMemo = objUserPrjGrantEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserPrjGrant");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUserPrjGrantEN objUserPrjGrantEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserPrjGrantEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserPrjGrantEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.UserId);
 var strUserId = objUserPrjGrantEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserPrjGrantEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.PrjId);
 var strPrjId = objUserPrjGrantEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserPrjGrantEN.RoleId  ==  "")
 {
 objUserPrjGrantEN.RoleId = null;
 }
 if (objUserPrjGrantEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.RoleId);
 var strRoleId = objUserPrjGrantEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objUserPrjGrantEN.VisitedNum !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.VisitedNum);
 arrValueListForInsert.Add(objUserPrjGrantEN.VisitedNum.ToString());
 }
 
 if (objUserPrjGrantEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.LastVisitedDate);
 var strLastVisitedDate = objUserPrjGrantEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objUserPrjGrantEN.OptId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.OptId);
 var strOptId = objUserPrjGrantEN.OptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptId + "'");
 }
 
 if (objUserPrjGrantEN.OptDate !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.OptDate);
 var strOptDate = objUserPrjGrantEN.OptDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptDate + "'");
 }
 
 if (objUserPrjGrantEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.Memo);
 var strMemo = objUserPrjGrantEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserPrjGrant");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUserPrjGrantEN objUserPrjGrantEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUserPrjGrantEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUserPrjGrantEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.UserId);
 var strUserId = objUserPrjGrantEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objUserPrjGrantEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.PrjId);
 var strPrjId = objUserPrjGrantEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUserPrjGrantEN.RoleId  ==  "")
 {
 objUserPrjGrantEN.RoleId = null;
 }
 if (objUserPrjGrantEN.RoleId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.RoleId);
 var strRoleId = objUserPrjGrantEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRoleId + "'");
 }
 
 if (objUserPrjGrantEN.VisitedNum !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.VisitedNum);
 arrValueListForInsert.Add(objUserPrjGrantEN.VisitedNum.ToString());
 }
 
 if (objUserPrjGrantEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.LastVisitedDate);
 var strLastVisitedDate = objUserPrjGrantEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objUserPrjGrantEN.OptId !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.OptId);
 var strOptId = objUserPrjGrantEN.OptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptId + "'");
 }
 
 if (objUserPrjGrantEN.OptDate !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.OptDate);
 var strOptDate = objUserPrjGrantEN.OptDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOptDate + "'");
 }
 
 if (objUserPrjGrantEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conUserPrjGrant.Memo);
 var strMemo = objUserPrjGrantEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UserPrjGrant");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUserPrjGrants(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UserPrjGrant");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conUserPrjGrant.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUserPrjGrantEN._CurrTabName ].NewRow();
objRow[conUserPrjGrant.UserId] = oRow[conUserPrjGrant.UserId].ToString().Trim(); //用户Id
objRow[conUserPrjGrant.PrjId] = oRow[conUserPrjGrant.PrjId].ToString().Trim(); //工程Id
objRow[conUserPrjGrant.RoleId] = oRow[conUserPrjGrant.RoleId].ToString().Trim(); //角色ID
objRow[conUserPrjGrant.VisitedNum] = oRow[conUserPrjGrant.VisitedNum].ToString().Trim(); //访问数
objRow[conUserPrjGrant.LastVisitedDate] = oRow[conUserPrjGrant.LastVisitedDate].ToString().Trim(); //最后访问时间
objRow[conUserPrjGrant.OptId] = oRow[conUserPrjGrant.OptId].ToString().Trim(); //操作者Id
objRow[conUserPrjGrant.OptDate] = oRow[conUserPrjGrant.OptDate].ToString().Trim(); //操作日期
objRow[conUserPrjGrant.Memo] = oRow[conUserPrjGrant.Memo].ToString().Trim(); //说明
 objDS.Tables[clsUserPrjGrantEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUserPrjGrantEN._CurrTabName);
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
 /// <param name = "objUserPrjGrantEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUserPrjGrantEN objUserPrjGrantEN)
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserPrjGrantEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
strSQL = "Select * from UserPrjGrant where mId = " + ""+ objUserPrjGrantEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUserPrjGrantEN._CurrTabName);
if (objDS.Tables[clsUserPrjGrantEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objUserPrjGrantEN.mId+"");
return false;
}
objRow = objDS.Tables[clsUserPrjGrantEN._CurrTabName].Rows[0];
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.UserId))
 {
objRow[conUserPrjGrant.UserId] = objUserPrjGrantEN.UserId; //用户Id
 }
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.PrjId))
 {
objRow[conUserPrjGrant.PrjId] = objUserPrjGrantEN.PrjId; //工程Id
 }
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.RoleId))
 {
objRow[conUserPrjGrant.RoleId] = objUserPrjGrantEN.RoleId; //角色ID
 }
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.VisitedNum))
 {
objRow[conUserPrjGrant.VisitedNum] = objUserPrjGrantEN.VisitedNum; //访问数
 }
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.LastVisitedDate))
 {
objRow[conUserPrjGrant.LastVisitedDate] = objUserPrjGrantEN.LastVisitedDate; //最后访问时间
 }
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptId))
 {
objRow[conUserPrjGrant.OptId] = objUserPrjGrantEN.OptId; //操作者Id
 }
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptDate))
 {
objRow[conUserPrjGrant.OptDate] = objUserPrjGrantEN.OptDate; //操作日期
 }
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.Memo))
 {
objRow[conUserPrjGrant.Memo] = objUserPrjGrantEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsUserPrjGrantEN._CurrTabName);
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserPrjGrantEN objUserPrjGrantEN)
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserPrjGrantEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UserPrjGrant Set ");
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.UserId))
 {
 if (objUserPrjGrantEN.UserId !=  null)
 {
 var strUserId = objUserPrjGrantEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserPrjGrant.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.UserId); //用户Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.PrjId))
 {
 if (objUserPrjGrantEN.PrjId !=  null)
 {
 var strPrjId = objUserPrjGrantEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUserPrjGrant.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.PrjId); //工程Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.RoleId))
 {
 if (objUserPrjGrantEN.RoleId  ==  "")
 {
 objUserPrjGrantEN.RoleId = null;
 }
 if (objUserPrjGrantEN.RoleId !=  null)
 {
 var strRoleId = objUserPrjGrantEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conUserPrjGrant.RoleId); //角色ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.RoleId); //角色ID
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.VisitedNum))
 {
 if (objUserPrjGrantEN.VisitedNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserPrjGrantEN.VisitedNum, conUserPrjGrant.VisitedNum); //访问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.VisitedNum); //访问数
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.LastVisitedDate))
 {
 if (objUserPrjGrantEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objUserPrjGrantEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastVisitedDate, conUserPrjGrant.LastVisitedDate); //最后访问时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.LastVisitedDate); //最后访问时间
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptId))
 {
 if (objUserPrjGrantEN.OptId !=  null)
 {
 var strOptId = objUserPrjGrantEN.OptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOptId, conUserPrjGrant.OptId); //操作者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.OptId); //操作者Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptDate))
 {
 if (objUserPrjGrantEN.OptDate !=  null)
 {
 var strOptDate = objUserPrjGrantEN.OptDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOptDate, conUserPrjGrant.OptDate); //操作日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.OptDate); //操作日期
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.Memo))
 {
 if (objUserPrjGrantEN.Memo !=  null)
 {
 var strMemo = objUserPrjGrantEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserPrjGrant.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserPrjGrantEN.mId); 
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
 /// <param name = "objUserPrjGrantEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUserPrjGrantEN objUserPrjGrantEN, string strCondition)
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserPrjGrantEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserPrjGrant Set ");
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.UserId))
 {
 if (objUserPrjGrantEN.UserId !=  null)
 {
 var strUserId = objUserPrjGrantEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.PrjId))
 {
 if (objUserPrjGrantEN.PrjId !=  null)
 {
 var strPrjId = objUserPrjGrantEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.RoleId))
 {
 if (objUserPrjGrantEN.RoleId  ==  "")
 {
 objUserPrjGrantEN.RoleId = null;
 }
 if (objUserPrjGrantEN.RoleId !=  null)
 {
 var strRoleId = objUserPrjGrantEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色ID
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色ID
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.VisitedNum))
 {
 if (objUserPrjGrantEN.VisitedNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserPrjGrantEN.VisitedNum, conUserPrjGrant.VisitedNum); //访问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.VisitedNum); //访问数
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.LastVisitedDate))
 {
 if (objUserPrjGrantEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objUserPrjGrantEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastVisitedDate = '{0}',", strLastVisitedDate); //最后访问时间
 }
 else
 {
 sbSQL.Append(" LastVisitedDate = null,"); //最后访问时间
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptId))
 {
 if (objUserPrjGrantEN.OptId !=  null)
 {
 var strOptId = objUserPrjGrantEN.OptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OptId = '{0}',", strOptId); //操作者Id
 }
 else
 {
 sbSQL.Append(" OptId = null,"); //操作者Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptDate))
 {
 if (objUserPrjGrantEN.OptDate !=  null)
 {
 var strOptDate = objUserPrjGrantEN.OptDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OptDate = '{0}',", strOptDate); //操作日期
 }
 else
 {
 sbSQL.Append(" OptDate = null,"); //操作日期
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.Memo))
 {
 if (objUserPrjGrantEN.Memo !=  null)
 {
 var strMemo = objUserPrjGrantEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserPrjGrantEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUserPrjGrantEN objUserPrjGrantEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserPrjGrantEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserPrjGrant Set ");
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.UserId))
 {
 if (objUserPrjGrantEN.UserId !=  null)
 {
 var strUserId = objUserPrjGrantEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.PrjId))
 {
 if (objUserPrjGrantEN.PrjId !=  null)
 {
 var strPrjId = objUserPrjGrantEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.RoleId))
 {
 if (objUserPrjGrantEN.RoleId  ==  "")
 {
 objUserPrjGrantEN.RoleId = null;
 }
 if (objUserPrjGrantEN.RoleId !=  null)
 {
 var strRoleId = objUserPrjGrantEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RoleId = '{0}',", strRoleId); //角色ID
 }
 else
 {
 sbSQL.Append(" RoleId = null,"); //角色ID
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.VisitedNum))
 {
 if (objUserPrjGrantEN.VisitedNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserPrjGrantEN.VisitedNum, conUserPrjGrant.VisitedNum); //访问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.VisitedNum); //访问数
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.LastVisitedDate))
 {
 if (objUserPrjGrantEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objUserPrjGrantEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastVisitedDate = '{0}',", strLastVisitedDate); //最后访问时间
 }
 else
 {
 sbSQL.Append(" LastVisitedDate = null,"); //最后访问时间
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptId))
 {
 if (objUserPrjGrantEN.OptId !=  null)
 {
 var strOptId = objUserPrjGrantEN.OptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OptId = '{0}',", strOptId); //操作者Id
 }
 else
 {
 sbSQL.Append(" OptId = null,"); //操作者Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptDate))
 {
 if (objUserPrjGrantEN.OptDate !=  null)
 {
 var strOptDate = objUserPrjGrantEN.OptDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OptDate = '{0}',", strOptDate); //操作日期
 }
 else
 {
 sbSQL.Append(" OptDate = null,"); //操作日期
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.Memo))
 {
 if (objUserPrjGrantEN.Memo !=  null)
 {
 var strMemo = objUserPrjGrantEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objUserPrjGrantEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUserPrjGrantEN objUserPrjGrantEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUserPrjGrantEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUserPrjGrantEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UserPrjGrant Set ");
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.UserId))
 {
 if (objUserPrjGrantEN.UserId !=  null)
 {
 var strUserId = objUserPrjGrantEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conUserPrjGrant.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.UserId); //用户Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.PrjId))
 {
 if (objUserPrjGrantEN.PrjId !=  null)
 {
 var strPrjId = objUserPrjGrantEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUserPrjGrant.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.PrjId); //工程Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.RoleId))
 {
 if (objUserPrjGrantEN.RoleId  ==  "")
 {
 objUserPrjGrantEN.RoleId = null;
 }
 if (objUserPrjGrantEN.RoleId !=  null)
 {
 var strRoleId = objUserPrjGrantEN.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRoleId, conUserPrjGrant.RoleId); //角色ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.RoleId); //角色ID
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.VisitedNum))
 {
 if (objUserPrjGrantEN.VisitedNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUserPrjGrantEN.VisitedNum, conUserPrjGrant.VisitedNum); //访问数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.VisitedNum); //访问数
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.LastVisitedDate))
 {
 if (objUserPrjGrantEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objUserPrjGrantEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastVisitedDate, conUserPrjGrant.LastVisitedDate); //最后访问时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.LastVisitedDate); //最后访问时间
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptId))
 {
 if (objUserPrjGrantEN.OptId !=  null)
 {
 var strOptId = objUserPrjGrantEN.OptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOptId, conUserPrjGrant.OptId); //操作者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.OptId); //操作者Id
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.OptDate))
 {
 if (objUserPrjGrantEN.OptDate !=  null)
 {
 var strOptDate = objUserPrjGrantEN.OptDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOptDate, conUserPrjGrant.OptDate); //操作日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.OptDate); //操作日期
 }
 }
 
 if (objUserPrjGrantEN.IsUpdated(conUserPrjGrant.Memo))
 {
 if (objUserPrjGrantEN.Memo !=  null)
 {
 var strMemo = objUserPrjGrantEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conUserPrjGrant.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUserPrjGrant.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objUserPrjGrantEN.mId); 
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("UserPrjGrant_Delete", values);
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
//删除UserPrjGrant本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserPrjGrant where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUserPrjGrant(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
//删除UserPrjGrant本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserPrjGrant where mId in (" + strKeyList + ")";
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
//删除UserPrjGrant本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UserPrjGrant where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUserPrjGrant(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: DelUserPrjGrant)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserPrjGrant where " + strCondition ;
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
public bool DelUserPrjGrantWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUserPrjGrantDA: DelUserPrjGrantWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UserPrjGrant where " + strCondition ;
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
 /// <param name = "objUserPrjGrantENS">源对象</param>
 /// <param name = "objUserPrjGrantENT">目标对象</param>
public void CopyTo(clsUserPrjGrantEN objUserPrjGrantENS, clsUserPrjGrantEN objUserPrjGrantENT)
{
objUserPrjGrantENT.mId = objUserPrjGrantENS.mId; //mId
objUserPrjGrantENT.UserId = objUserPrjGrantENS.UserId; //用户Id
objUserPrjGrantENT.PrjId = objUserPrjGrantENS.PrjId; //工程Id
objUserPrjGrantENT.RoleId = objUserPrjGrantENS.RoleId; //角色ID
objUserPrjGrantENT.VisitedNum = objUserPrjGrantENS.VisitedNum; //访问数
objUserPrjGrantENT.LastVisitedDate = objUserPrjGrantENS.LastVisitedDate; //最后访问时间
objUserPrjGrantENT.OptId = objUserPrjGrantENS.OptId; //操作者Id
objUserPrjGrantENT.OptDate = objUserPrjGrantENS.OptDate; //操作日期
objUserPrjGrantENT.Memo = objUserPrjGrantENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUserPrjGrantEN objUserPrjGrantEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUserPrjGrantEN.UserId, conUserPrjGrant.UserId);
clsCheckSql.CheckFieldNotNull(objUserPrjGrantEN.PrjId, conUserPrjGrant.PrjId);
clsCheckSql.CheckFieldNotNull(objUserPrjGrantEN.RoleId, conUserPrjGrant.RoleId);
//检查字段长度
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.UserId, 18, conUserPrjGrant.UserId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.PrjId, 4, conUserPrjGrant.PrjId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.RoleId, 8, conUserPrjGrant.RoleId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.LastVisitedDate, 20, conUserPrjGrant.LastVisitedDate);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.OptId, 18, conUserPrjGrant.OptId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.OptDate, 20, conUserPrjGrant.OptDate);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.Memo, 1000, conUserPrjGrant.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objUserPrjGrantEN.RoleId, 8, conUserPrjGrant.RoleId);
 objUserPrjGrantEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUserPrjGrantEN objUserPrjGrantEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.UserId, 18, conUserPrjGrant.UserId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.PrjId, 4, conUserPrjGrant.PrjId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.RoleId, 8, conUserPrjGrant.RoleId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.LastVisitedDate, 20, conUserPrjGrant.LastVisitedDate);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.OptId, 18, conUserPrjGrant.OptId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.OptDate, 20, conUserPrjGrant.OptDate);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.Memo, 1000, conUserPrjGrant.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserPrjGrantEN.RoleId, 8, conUserPrjGrant.RoleId);
 objUserPrjGrantEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUserPrjGrantEN objUserPrjGrantEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.UserId, 18, conUserPrjGrant.UserId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.PrjId, 4, conUserPrjGrant.PrjId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.RoleId, 8, conUserPrjGrant.RoleId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.LastVisitedDate, 20, conUserPrjGrant.LastVisitedDate);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.OptId, 18, conUserPrjGrant.OptId);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.OptDate, 20, conUserPrjGrant.OptDate);
clsCheckSql.CheckFieldLen(objUserPrjGrantEN.Memo, 1000, conUserPrjGrant.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUserPrjGrantEN.UserId, conUserPrjGrant.UserId);
clsCheckSql.CheckSqlInjection4Field(objUserPrjGrantEN.PrjId, conUserPrjGrant.PrjId);
clsCheckSql.CheckSqlInjection4Field(objUserPrjGrantEN.RoleId, conUserPrjGrant.RoleId);
clsCheckSql.CheckSqlInjection4Field(objUserPrjGrantEN.LastVisitedDate, conUserPrjGrant.LastVisitedDate);
clsCheckSql.CheckSqlInjection4Field(objUserPrjGrantEN.OptId, conUserPrjGrant.OptId);
clsCheckSql.CheckSqlInjection4Field(objUserPrjGrantEN.OptDate, conUserPrjGrant.OptDate);
clsCheckSql.CheckSqlInjection4Field(objUserPrjGrantEN.Memo, conUserPrjGrant.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objUserPrjGrantEN.RoleId, 8, conUserPrjGrant.RoleId);
 objUserPrjGrantEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UserPrjGrant(UserPrjGrant),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUserPrjGrantEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUserPrjGrantEN objUserPrjGrantEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUserPrjGrantEN.PrjId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objUserPrjGrantEN.UserId);
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserPrjGrantEN._CurrTabName);
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUserPrjGrantEN._CurrTabName, strCondition);
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
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
 objSQL = clsUserPrjGrantDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}