
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebApiIPAndPortTabDA
 表名:WebApiIPAndPortTab(00050529)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:35:07
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
 /// WebApiIP表(WebApiIPAndPortTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsWebApiIPAndPortTabDA : clsCommBase4DA
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
 return clsWebApiIPAndPortTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsWebApiIPAndPortTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsWebApiIPAndPortTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsWebApiIPAndPortTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsWebApiIPAndPortTabEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_WebApiIPAndPortTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTable_WebApiIPAndPortTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebApiIPAndPortTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebApiIPAndPortTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from WebApiIPAndPortTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} WebApiIPAndPortTab.* " + 
$"from WebApiIPAndPortTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and WebApiIPAndPortTab.mId not in " + 
$"(Select top {intTop_In} WebApiIPAndPortTab.mId from WebApiIPAndPortTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebApiIPAndPortTab where {1} and mId not in (Select top {2} mId from WebApiIPAndPortTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebApiIPAndPortTab where {1} and mId not in (Select top {3} mId from WebApiIPAndPortTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} WebApiIPAndPortTab.* " + 
$"from WebApiIPAndPortTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and WebApiIPAndPortTab.mId not in " + 
$"(Select top {intTop_In} WebApiIPAndPortTab.mId from WebApiIPAndPortTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebApiIPAndPortTab where {1} and mId not in (Select top {2} mId from WebApiIPAndPortTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebApiIPAndPortTab where {1} and mId not in (Select top {3} mId from WebApiIPAndPortTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsWebApiIPAndPortTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA:GetObjLst)", objException.Message));
}
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = TransNullToInt(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = TransNullToInt(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWebApiIPAndPortTabDA: GetObjLst)", objException.Message));
}
objWebApiIPAndPortTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWebApiIPAndPortTabEN);
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
public List<clsWebApiIPAndPortTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsWebApiIPAndPortTabEN> arrObjLst = new List<clsWebApiIPAndPortTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = TransNullToInt(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = TransNullToInt(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWebApiIPAndPortTabDA: GetObjLst)", objException.Message));
}
objWebApiIPAndPortTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWebApiIPAndPortTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetWebApiIPAndPortTab(ref clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where mId = " + ""+ objWebApiIPAndPortTabEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objWebApiIPAndPortTabEN.mId = TransNullToInt(objDT.Rows[0][conWebApiIPAndPortTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objWebApiIPAndPortTabEN.WebApiIPAndPort = objDT.Rows[0][conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort(字段类型:varchar,字段长度:50,是否可空:True)
 objWebApiIPAndPortTabEN.WebApiVirtualPath = objDT.Rows[0][conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径(字段类型:varchar,字段长度:50,是否可空:True)
 objWebApiIPAndPortTabEN.OrderNum = TransNullToInt(objDT.Rows[0][conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objWebApiIPAndPortTabEN.UpdDate = objDT.Rows[0][conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWebApiIPAndPortTabEN.UpdUserId = objDT.Rows[0][conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objWebApiIPAndPortTabEN.Memo = objDT.Rows[0][conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsWebApiIPAndPortTabDA: GetWebApiIPAndPortTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsWebApiIPAndPortTabEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
 objWebApiIPAndPortTabEN.mId = Int32.Parse(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort(字段类型:varchar,字段长度:50,是否可空:True)
 objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径(字段类型:varchar,字段长度:50,是否可空:True)
 objWebApiIPAndPortTabEN.OrderNum = Int32.Parse(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsWebApiIPAndPortTabDA: GetObjBymId)", objException.Message));
}
return objWebApiIPAndPortTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsWebApiIPAndPortTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN()
{
mId = TransNullToInt(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()), //mId
WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(), //WebApiIPAndPort
WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(), //WebApi虚拟路径
OrderNum = TransNullToInt(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim() //说明
};
objWebApiIPAndPortTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebApiIPAndPortTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsWebApiIPAndPortTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsWebApiIPAndPortTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = TransNullToInt(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = TransNullToInt(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsWebApiIPAndPortTabDA: GetObjByDataRowWebApiIPAndPortTab)", objException.Message));
}
objWebApiIPAndPortTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebApiIPAndPortTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsWebApiIPAndPortTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN = new clsWebApiIPAndPortTabEN();
try
{
objWebApiIPAndPortTabEN.mId = TransNullToInt(objRow[conWebApiIPAndPortTab.mId].ToString().Trim()); //mId
objWebApiIPAndPortTabEN.WebApiIPAndPort = objRow[conWebApiIPAndPortTab.WebApiIPAndPort] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objWebApiIPAndPortTabEN.WebApiVirtualPath = objRow[conWebApiIPAndPortTab.WebApiVirtualPath] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objWebApiIPAndPortTabEN.OrderNum = TransNullToInt(objRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim()); //序号
objWebApiIPAndPortTabEN.UpdDate = objRow[conWebApiIPAndPortTab.UpdDate] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objWebApiIPAndPortTabEN.UpdUserId = objRow[conWebApiIPAndPortTab.UpdUserId] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objWebApiIPAndPortTabEN.Memo = objRow[conWebApiIPAndPortTab.Memo] == DBNull.Value ? null : objRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsWebApiIPAndPortTabDA: GetObjByDataRow)", objException.Message));
}
objWebApiIPAndPortTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebApiIPAndPortTabEN;
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
objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWebApiIPAndPortTabEN._CurrTabName, conWebApiIPAndPortTab.mId, 8, "");
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
objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWebApiIPAndPortTabEN._CurrTabName, conWebApiIPAndPortTab.mId, 8, strPrefix);
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from WebApiIPAndPortTab where " + strCondition;
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from WebApiIPAndPortTab where " + strCondition;
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WebApiIPAndPortTab", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WebApiIPAndPortTab", strCondition))
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
objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("WebApiIPAndPortTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
 {
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebApiIPAndPortTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WebApiIPAndPortTab");
objRow = objDS.Tables["WebApiIPAndPortTab"].NewRow();
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  "")
 {
objRow[conWebApiIPAndPortTab.WebApiIPAndPort] = objWebApiIPAndPortTabEN.WebApiIPAndPort; //WebApiIPAndPort
 }
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  "")
 {
objRow[conWebApiIPAndPortTab.WebApiVirtualPath] = objWebApiIPAndPortTabEN.WebApiVirtualPath; //WebApi虚拟路径
 }
objRow[conWebApiIPAndPortTab.OrderNum] = objWebApiIPAndPortTabEN.OrderNum; //序号
 if (objWebApiIPAndPortTabEN.UpdDate !=  "")
 {
objRow[conWebApiIPAndPortTab.UpdDate] = objWebApiIPAndPortTabEN.UpdDate; //修改日期
 }
 if (objWebApiIPAndPortTabEN.UpdUserId !=  "")
 {
objRow[conWebApiIPAndPortTab.UpdUserId] = objWebApiIPAndPortTabEN.UpdUserId; //修改用户Id
 }
 if (objWebApiIPAndPortTabEN.Memo !=  "")
 {
objRow[conWebApiIPAndPortTab.Memo] = objWebApiIPAndPortTabEN.Memo; //说明
 }
objDS.Tables[clsWebApiIPAndPortTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsWebApiIPAndPortTabEN._CurrTabName);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebApiIPAndPortTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.WebApiIPAndPort);
 var strWebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiIPAndPort + "'");
 }
 
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.WebApiVirtualPath);
 var strWebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiVirtualPath + "'");
 }
 
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.OrderNum);
 arrValueListForInsert.Add(objWebApiIPAndPortTabEN.OrderNum.ToString());
 
 if (objWebApiIPAndPortTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.UpdDate);
 var strUpdDate = objWebApiIPAndPortTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebApiIPAndPortTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.UpdUserId);
 var strUpdUserId = objWebApiIPAndPortTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objWebApiIPAndPortTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.Memo);
 var strMemo = objWebApiIPAndPortTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebApiIPAndPortTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebApiIPAndPortTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.WebApiIPAndPort);
 var strWebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiIPAndPort + "'");
 }
 
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.WebApiVirtualPath);
 var strWebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiVirtualPath + "'");
 }
 
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.OrderNum);
 arrValueListForInsert.Add(objWebApiIPAndPortTabEN.OrderNum.ToString());
 
 if (objWebApiIPAndPortTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.UpdDate);
 var strUpdDate = objWebApiIPAndPortTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebApiIPAndPortTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.UpdUserId);
 var strUpdUserId = objWebApiIPAndPortTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objWebApiIPAndPortTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.Memo);
 var strMemo = objWebApiIPAndPortTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebApiIPAndPortTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebApiIPAndPortTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.WebApiIPAndPort);
 var strWebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiIPAndPort + "'");
 }
 
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.WebApiVirtualPath);
 var strWebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiVirtualPath + "'");
 }
 
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.OrderNum);
 arrValueListForInsert.Add(objWebApiIPAndPortTabEN.OrderNum.ToString());
 
 if (objWebApiIPAndPortTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.UpdDate);
 var strUpdDate = objWebApiIPAndPortTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebApiIPAndPortTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.UpdUserId);
 var strUpdUserId = objWebApiIPAndPortTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objWebApiIPAndPortTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.Memo);
 var strMemo = objWebApiIPAndPortTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebApiIPAndPortTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebApiIPAndPortTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.WebApiIPAndPort);
 var strWebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiIPAndPort + "'");
 }
 
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.WebApiVirtualPath);
 var strWebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebApiVirtualPath + "'");
 }
 
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.OrderNum);
 arrValueListForInsert.Add(objWebApiIPAndPortTabEN.OrderNum.ToString());
 
 if (objWebApiIPAndPortTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.UpdDate);
 var strUpdDate = objWebApiIPAndPortTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebApiIPAndPortTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.UpdUserId);
 var strUpdUserId = objWebApiIPAndPortTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objWebApiIPAndPortTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebApiIPAndPortTab.Memo);
 var strMemo = objWebApiIPAndPortTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebApiIPAndPortTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewWebApiIPAndPortTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WebApiIPAndPortTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conWebApiIPAndPortTab.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsWebApiIPAndPortTabEN._CurrTabName ].NewRow();
objRow[conWebApiIPAndPortTab.WebApiIPAndPort] = oRow[conWebApiIPAndPortTab.WebApiIPAndPort].ToString().Trim(); //WebApiIPAndPort
objRow[conWebApiIPAndPortTab.WebApiVirtualPath] = oRow[conWebApiIPAndPortTab.WebApiVirtualPath].ToString().Trim(); //WebApi虚拟路径
objRow[conWebApiIPAndPortTab.OrderNum] = oRow[conWebApiIPAndPortTab.OrderNum].ToString().Trim(); //序号
objRow[conWebApiIPAndPortTab.UpdDate] = oRow[conWebApiIPAndPortTab.UpdDate].ToString().Trim(); //修改日期
objRow[conWebApiIPAndPortTab.UpdUserId] = oRow[conWebApiIPAndPortTab.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conWebApiIPAndPortTab.Memo] = oRow[conWebApiIPAndPortTab.Memo].ToString().Trim(); //说明
 objDS.Tables[clsWebApiIPAndPortTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsWebApiIPAndPortTabEN._CurrTabName);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebApiIPAndPortTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
strSQL = "Select * from WebApiIPAndPortTab where mId = " + ""+ objWebApiIPAndPortTabEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsWebApiIPAndPortTabEN._CurrTabName);
if (objDS.Tables[clsWebApiIPAndPortTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objWebApiIPAndPortTabEN.mId+"");
return false;
}
objRow = objDS.Tables[clsWebApiIPAndPortTabEN._CurrTabName].Rows[0];
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiIPAndPort))
 {
objRow[conWebApiIPAndPortTab.WebApiIPAndPort] = objWebApiIPAndPortTabEN.WebApiIPAndPort; //WebApiIPAndPort
 }
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiVirtualPath))
 {
objRow[conWebApiIPAndPortTab.WebApiVirtualPath] = objWebApiIPAndPortTabEN.WebApiVirtualPath; //WebApi虚拟路径
 }
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.OrderNum))
 {
objRow[conWebApiIPAndPortTab.OrderNum] = objWebApiIPAndPortTabEN.OrderNum; //序号
 }
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdDate))
 {
objRow[conWebApiIPAndPortTab.UpdDate] = objWebApiIPAndPortTabEN.UpdDate; //修改日期
 }
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdUserId))
 {
objRow[conWebApiIPAndPortTab.UpdUserId] = objWebApiIPAndPortTabEN.UpdUserId; //修改用户Id
 }
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.Memo))
 {
objRow[conWebApiIPAndPortTab.Memo] = objWebApiIPAndPortTabEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsWebApiIPAndPortTabEN._CurrTabName);
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebApiIPAndPortTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update WebApiIPAndPortTab Set ");
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiIPAndPort))
 {
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  null)
 {
 var strWebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiIPAndPort, conWebApiIPAndPortTab.WebApiIPAndPort); //WebApiIPAndPort
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.WebApiIPAndPort); //WebApiIPAndPort
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiVirtualPath))
 {
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  null)
 {
 var strWebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiVirtualPath, conWebApiIPAndPortTab.WebApiVirtualPath); //WebApi虚拟路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.WebApiVirtualPath); //WebApi虚拟路径
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objWebApiIPAndPortTabEN.OrderNum, conWebApiIPAndPortTab.OrderNum); //序号
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdDate))
 {
 if (objWebApiIPAndPortTabEN.UpdDate !=  null)
 {
 var strUpdDate = objWebApiIPAndPortTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWebApiIPAndPortTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.UpdDate); //修改日期
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdUserId))
 {
 if (objWebApiIPAndPortTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objWebApiIPAndPortTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conWebApiIPAndPortTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.Memo))
 {
 if (objWebApiIPAndPortTabEN.Memo !=  null)
 {
 var strMemo = objWebApiIPAndPortTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWebApiIPAndPortTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objWebApiIPAndPortTabEN.mId); 
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
 /// <param name = "objWebApiIPAndPortTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strCondition)
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebApiIPAndPortTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebApiIPAndPortTab Set ");
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiIPAndPort))
 {
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  null)
 {
 var strWebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiIPAndPort = '{0}',", strWebApiIPAndPort); //WebApiIPAndPort
 }
 else
 {
 sbSQL.Append(" WebApiIPAndPort = null,"); //WebApiIPAndPort
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiVirtualPath))
 {
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  null)
 {
 var strWebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiVirtualPath = '{0}',", strWebApiVirtualPath); //WebApi虚拟路径
 }
 else
 {
 sbSQL.Append(" WebApiVirtualPath = null,"); //WebApi虚拟路径
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objWebApiIPAndPortTabEN.OrderNum); //序号
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdDate))
 {
 if (objWebApiIPAndPortTabEN.UpdDate !=  null)
 {
 var strUpdDate = objWebApiIPAndPortTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdUserId))
 {
 if (objWebApiIPAndPortTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objWebApiIPAndPortTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.Memo))
 {
 if (objWebApiIPAndPortTabEN.Memo !=  null)
 {
 var strMemo = objWebApiIPAndPortTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objWebApiIPAndPortTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebApiIPAndPortTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebApiIPAndPortTab Set ");
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiIPAndPort))
 {
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  null)
 {
 var strWebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiIPAndPort = '{0}',", strWebApiIPAndPort); //WebApiIPAndPort
 }
 else
 {
 sbSQL.Append(" WebApiIPAndPort = null,"); //WebApiIPAndPort
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiVirtualPath))
 {
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  null)
 {
 var strWebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebApiVirtualPath = '{0}',", strWebApiVirtualPath); //WebApi虚拟路径
 }
 else
 {
 sbSQL.Append(" WebApiVirtualPath = null,"); //WebApi虚拟路径
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objWebApiIPAndPortTabEN.OrderNum); //序号
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdDate))
 {
 if (objWebApiIPAndPortTabEN.UpdDate !=  null)
 {
 var strUpdDate = objWebApiIPAndPortTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdUserId))
 {
 if (objWebApiIPAndPortTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objWebApiIPAndPortTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.Memo))
 {
 if (objWebApiIPAndPortTabEN.Memo !=  null)
 {
 var strMemo = objWebApiIPAndPortTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objWebApiIPAndPortTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWebApiIPAndPortTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebApiIPAndPortTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebApiIPAndPortTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebApiIPAndPortTab Set ");
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiIPAndPort))
 {
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort !=  null)
 {
 var strWebApiIPAndPort = objWebApiIPAndPortTabEN.WebApiIPAndPort.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiIPAndPort, conWebApiIPAndPortTab.WebApiIPAndPort); //WebApiIPAndPort
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.WebApiIPAndPort); //WebApiIPAndPort
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.WebApiVirtualPath))
 {
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath !=  null)
 {
 var strWebApiVirtualPath = objWebApiIPAndPortTabEN.WebApiVirtualPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebApiVirtualPath, conWebApiIPAndPortTab.WebApiVirtualPath); //WebApi虚拟路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.WebApiVirtualPath); //WebApi虚拟路径
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objWebApiIPAndPortTabEN.OrderNum, conWebApiIPAndPortTab.OrderNum); //序号
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdDate))
 {
 if (objWebApiIPAndPortTabEN.UpdDate !=  null)
 {
 var strUpdDate = objWebApiIPAndPortTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWebApiIPAndPortTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.UpdDate); //修改日期
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.UpdUserId))
 {
 if (objWebApiIPAndPortTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objWebApiIPAndPortTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conWebApiIPAndPortTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objWebApiIPAndPortTabEN.IsUpdated(conWebApiIPAndPortTab.Memo))
 {
 if (objWebApiIPAndPortTabEN.Memo !=  null)
 {
 var strMemo = objWebApiIPAndPortTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWebApiIPAndPortTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebApiIPAndPortTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objWebApiIPAndPortTabEN.mId); 
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("WebApiIPAndPortTab_Delete", values);
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
//删除WebApiIPAndPortTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebApiIPAndPortTab where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelWebApiIPAndPortTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
//删除WebApiIPAndPortTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebApiIPAndPortTab where mId in (" + strKeyList + ")";
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
//删除WebApiIPAndPortTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebApiIPAndPortTab where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelWebApiIPAndPortTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: DelWebApiIPAndPortTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WebApiIPAndPortTab where " + strCondition ;
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
public bool DelWebApiIPAndPortTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsWebApiIPAndPortTabDA: DelWebApiIPAndPortTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WebApiIPAndPortTab where " + strCondition ;
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
 /// <param name = "objWebApiIPAndPortTabENS">源对象</param>
 /// <param name = "objWebApiIPAndPortTabENT">目标对象</param>
public void CopyTo(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENS, clsWebApiIPAndPortTabEN objWebApiIPAndPortTabENT)
{
objWebApiIPAndPortTabENT.mId = objWebApiIPAndPortTabENS.mId; //mId
objWebApiIPAndPortTabENT.WebApiIPAndPort = objWebApiIPAndPortTabENS.WebApiIPAndPort; //WebApiIPAndPort
objWebApiIPAndPortTabENT.WebApiVirtualPath = objWebApiIPAndPortTabENS.WebApiVirtualPath; //WebApi虚拟路径
objWebApiIPAndPortTabENT.OrderNum = objWebApiIPAndPortTabENS.OrderNum; //序号
objWebApiIPAndPortTabENT.UpdDate = objWebApiIPAndPortTabENS.UpdDate; //修改日期
objWebApiIPAndPortTabENT.UpdUserId = objWebApiIPAndPortTabENS.UpdUserId; //修改用户Id
objWebApiIPAndPortTabENT.Memo = objWebApiIPAndPortTabENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objWebApiIPAndPortTabEN.OrderNum, conWebApiIPAndPortTab.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.WebApiIPAndPort, 50, conWebApiIPAndPortTab.WebApiIPAndPort);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.WebApiVirtualPath, 50, conWebApiIPAndPortTab.WebApiVirtualPath);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.UpdDate, 20, conWebApiIPAndPortTab.UpdDate);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.UpdUserId, 20, conWebApiIPAndPortTab.UpdUserId);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.Memo, 1000, conWebApiIPAndPortTab.Memo);
//检查字段外键固定长度
 objWebApiIPAndPortTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.WebApiIPAndPort, 50, conWebApiIPAndPortTab.WebApiIPAndPort);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.WebApiVirtualPath, 50, conWebApiIPAndPortTab.WebApiVirtualPath);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.UpdDate, 20, conWebApiIPAndPortTab.UpdDate);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.UpdUserId, 20, conWebApiIPAndPortTab.UpdUserId);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.Memo, 1000, conWebApiIPAndPortTab.Memo);
//检查外键字段长度
 objWebApiIPAndPortTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.WebApiIPAndPort, 50, conWebApiIPAndPortTab.WebApiIPAndPort);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.WebApiVirtualPath, 50, conWebApiIPAndPortTab.WebApiVirtualPath);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.UpdDate, 20, conWebApiIPAndPortTab.UpdDate);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.UpdUserId, 20, conWebApiIPAndPortTab.UpdUserId);
clsCheckSql.CheckFieldLen(objWebApiIPAndPortTabEN.Memo, 1000, conWebApiIPAndPortTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objWebApiIPAndPortTabEN.WebApiIPAndPort, conWebApiIPAndPortTab.WebApiIPAndPort);
clsCheckSql.CheckSqlInjection4Field(objWebApiIPAndPortTabEN.WebApiVirtualPath, conWebApiIPAndPortTab.WebApiVirtualPath);
clsCheckSql.CheckSqlInjection4Field(objWebApiIPAndPortTabEN.UpdDate, conWebApiIPAndPortTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objWebApiIPAndPortTabEN.UpdUserId, conWebApiIPAndPortTab.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objWebApiIPAndPortTabEN.Memo, conWebApiIPAndPortTab.Memo);
//检查外键字段长度
 objWebApiIPAndPortTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--WebApiIPAndPortTab(WebApiIP表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objWebApiIPAndPortTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsWebApiIPAndPortTabEN objWebApiIPAndPortTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objWebApiIPAndPortTabEN.WebApiIPAndPort == null)
{
 sbCondition.AppendFormat(" and WebApiIPAndPort is null");
}
else
{
 sbCondition.AppendFormat(" and WebApiIPAndPort = '{0}'", objWebApiIPAndPortTabEN.WebApiIPAndPort);
}
 if (objWebApiIPAndPortTabEN.WebApiVirtualPath == null)
{
 sbCondition.AppendFormat(" and WebApiVirtualPath is null");
}
else
{
 sbCondition.AppendFormat(" and WebApiVirtualPath = '{0}'", objWebApiIPAndPortTabEN.WebApiVirtualPath);
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWebApiIPAndPortTabEN._CurrTabName);
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWebApiIPAndPortTabEN._CurrTabName, strCondition);
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
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
 objSQL = clsWebApiIPAndPortTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}